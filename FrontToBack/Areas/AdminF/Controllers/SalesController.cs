using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]
    public class SalesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public SalesController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<Sale> sales = _db.Sales.ToList();
            List<SaleVM> saleVMs = new List<SaleVM>();

            foreach (Sale sale in sales)
            {
                AppUser user = await _userManager.FindByIdAsync(sale.AppUserId);
                SaleVM saleVM = new SaleVM
                {
                    Id = sale.Id,
                    Date = sale.Date,
                    Total = sale.Total,
                    Email = user.Email,
                    Fullname = user.Fullname,
                    SaleProducts = _db.SaleProducts.Where(sp => sp.SaleId == sale.Id).Include(sp => sp.Product).ToList()
                };
                saleVMs.Add(saleVM);
            }
            return View(saleVMs);
        }
    }
}