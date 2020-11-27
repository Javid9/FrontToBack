﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Extentions;
using FrontToBack.Helpers;
using FrontToBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Sliders);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider slider =await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        public IActionResult Create()
        {
            if (_db.Sliders.Count() >= 5)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        #region Multi file upload
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photos"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            int canUploadCount = 5-(_db.Sliders.Count());
            if (canUploadCount < slider.Photos.Length)
            {
                ModelState.AddModelError("Photos", $"Maxsimum yukleye bileceyiniz shekil sayi - {canUploadCount}");
                return View();
            }

            foreach (IFormFile photo in slider.Photos)
            {
                if (!photo.IsImage())
                {
                    ModelState.AddModelError("Photos", "Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photos", $"{photo.FileName} - Sheklinin olchusu 200kb-dan artiqdir");
                    return View();
                }
                string fileName = await photo.SaveImg(_env.WebRootPath, "img");

                Slider newSlider = new Slider();
                newSlider.Image = fileName;
                await _db.Sliders.AddAsync(newSlider);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region One file upload
        //public async Task<IActionResult> Create(Slider slider)
        //{
        //    if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
        //    {
        //        return View();
        //    }

        //    if (!slider.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
        //        return View();
        //    }

        //    if (slider.Photo.MaxLength(200))
        //    {
        //        ModelState.AddModelError("Photo", "Shekilin olchusu max 200kb ola biler");
        //        return View();
        //    }

        //    if (_db.Sliders.Count() >= 5)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    //string path = Path.Combine("img", "ttt");
        //    string fileName = await slider.Photo.SaveImg(_env.WebRootPath, "img");

        //    slider.Image = fileName;
        //    await _db.Sliders.AddAsync(slider);
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        #endregion


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", slider.Image);

            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Slider slider)
        {
            if (id == null) return NotFound();
            if (slider.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (slider.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu max 200kb ola biler");
                    return View();
                }

                Slider dbSlider =await _db.Sliders.FindAsync(id);
                if (dbSlider == null) return NotFound();

                Helper.DeleteImage(_env.WebRootPath, "img", dbSlider.Image);

                string fileName = await slider.Photo.SaveImg(_env.WebRootPath, "img");

                dbSlider.Image = fileName;
                await _db.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));
        }
    }
}