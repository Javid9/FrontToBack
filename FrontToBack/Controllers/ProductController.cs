using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        private int _count;
        public ProductController(AppDbContext db)
        {
            _db = db;
            _count= _db.Products.Count();
        }

        public IActionResult Index()
        {
            ViewBag.ProductCount = _count;
            return View();
        }
        [AllowAnonymous]
        public IActionResult Load(int skip)
        {
            if(skip>= _count)
            {
                return Content("Qaqa get qiragda oyna");
            }
            IEnumerable<Product> model = _db.Products.Include(p => p.Category).Skip(skip).Take(8);
            return PartialView("_ProductPartial", model);
            #region Old Version
            //return Json(_db.Products.Select(p=>new ProductVM { 
            //    Id=p.Id,
            //    Title=p.Title,
            //    Image=p.Image,
            //    Price=p.Price,
            //    Category=p.Category
            //}).Skip(8).Take(8));
            #endregion
        }
        [AllowAnonymous]
        public IActionResult Search(string search)
        {
            IEnumerable<Product> model =
                _db.Products.Where(p => p.Title.ToLower().Contains(search.ToLower())).OrderByDescending(p=>p.Id).Take(10);
            return PartialView("_SearchProductPartial", model);
        }
    }
}