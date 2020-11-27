using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            //HttpContext.Session.SetString("group","P116");
            //Response.Cookies.Append("name", "Ulvi", new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
            HomeVM homeVM = new HomeVM
            {
                PageSign= _db.PageSigns.FirstOrDefault(),
                Sliders= _db.Sliders,
                Categories=_db.Categories,
                About=_db.Abouts.FirstOrDefault(),
                Experts=_db.Experts,
                Subscribe=_db.Subscribes.FirstOrDefault()
            };
            return View(homeVM);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            if (User.Identity.IsAuthenticated)
            {
                Product product = await _db.Products.FindAsync(id);
                if (product == null) return NotFound();

                List<BasketVM> products;
                string existBasket = Request.Cookies["basket"];
                if (existBasket == null)
                {
                    products = new List<BasketVM>();
                }
                else
                {
                    products = JsonConvert.DeserializeObject<List<BasketVM>>(existBasket);
                }

                BasketVM existProduct = products.FirstOrDefault(p => p.Id == id && p.Username== User.Identity.Name);
                if (existProduct == null)
                {
                    BasketVM newProduct = new BasketVM
                    {
                        Id = product.Id,
                        Count = 1,
                        Username = User.Identity.Name
                        
                    };
                    products.Add(newProduct);
                }
                else
                {
                    existProduct.Count++;
                }


                string basket = JsonConvert.SerializeObject(products);
                Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Login", "Account");
        }


        public async Task<IActionResult> Basket()
        {
            //string session = HttpContext.Session.GetString("group");
            //string cookie = Request.Cookies["name"];
            //return Content(session+" "+cookie);

            
            if (User.Identity.IsAuthenticated)
            {
                string basket = Request.Cookies["basket"];
                List<BasketVM> products = new List<BasketVM>();
                List<BasketVM> userProdcut = new List<BasketVM>();
                if (basket != null)
                {
                    products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                    foreach (BasketVM item in products)
                    {
                        if(item.Username == User.Identity.Name)
                        {
                            Product dbProduct = await _db.Products.FindAsync(item.Id);
                            item.Price = dbProduct.Price;
                            item.Image = dbProduct.Image;
                            item.Title = dbProduct.Title;
                            userProdcut.Add(item);
                        }
                    }
                       
                }

                return View(userProdcut);
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ActionName("Basket")]
        public async Task<IActionResult> BasketSale()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                Sale sale = new Sale
                {
                    Date = DateTime.Now,
                    AppUserId = appUser.Id
                };

                List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);

                List<Product> dbProducts = new List<Product>();
                foreach (BasketVM item in basketProducts)
                {
                    
                    Product dbProduct = await _db.Products.FindAsync(item.Id);
                    if(dbProduct.Count < item.Count)
                    {
                        TempData["error"] = $"{dbProduct.Title} mehsulundan {dbProduct.Count} eded qalib,zehmet olmasa duzelish edin!!!";
                        return RedirectToAction("Basket");
                    }
                    dbProducts.Add(dbProduct);
                }

                List<SaleProduct> saleProducts = new List<SaleProduct>();

                double total = 0;
                foreach (BasketVM pro in basketProducts)
                {
                    if (pro.Username == User.Identity.Name)
                    {
                        Product dbProduct = dbProducts.Find(p => p.Id == pro.Id);

                        await DecreaseProductCount(dbProduct, pro);

                        SaleProduct saleProduct = new SaleProduct
                        {
                            Price = dbProduct.Price,
                            Count = pro.Count,
                            ProductId = pro.Id,
                            SaleId = sale.Id
                        };
                        total += pro.Count * dbProduct.Price;
                        saleProducts.Add(saleProduct);
                    }
                   
                }
                sale.Total = total;
                sale.SaleProducts = saleProducts;

                await _db.Sales.AddAsync(sale);
                await _db.SaveChangesAsync();
                TempData["success"] = "Alish-verishiniz ugurla yerine yetirildi";
                return RedirectToAction("Basket");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        private async Task DecreaseProductCount(Product dbProduct,BasketVM basketPro)
        {
            dbProduct.Count -=  basketPro.Count;
            await _db.SaveChangesAsync();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            string existBasket = Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(existBasket);
            BasketVM product = products.Find(p => p.Id == id);
            products.Remove(product);
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            return RedirectToAction(nameof(Basket));
       
        }
    }
}