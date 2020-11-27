using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Products.Count()/5);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_db.Products.Include(p => p.Category).OrderByDescending(p => p.Id).Take(5).ToList());
            }
            else
            {
                return View(_db.Products.Include(p => p.Category).OrderByDescending(p => p.Id).Skip(((int)page-1)*5).Take(5).ToList());
            }
            
        }
    }
}