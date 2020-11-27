using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, 
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();

            AppUser loginUser =await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("","Email or password is wrong!!!");
                return View(login);
            }
            if (!loginUser.IsActivated)
            {
                ModelState.AddModelError("", "Email is disabled!!!");
                return View(login);
            }

            var signInResult=await _signInManager.PasswordSignInAsync(loginUser, login.Password,true,true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "The account is locked out!!!");
                return View(login);
            }
            if (!signInResult.Succeeded)
            {
                 ModelState.AddModelError("","Email or password is wrong!!!");
                return View(login);
            }

            string role=(await _userManager.GetRolesAsync(loginUser))[0];
            if (role == "Admin")
            {
                return RedirectToAction("Index", "Dashboard",new { area = "AdminF" });
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {
                Fullname=register.Fullname,
                Email=register.Email,
                UserName=register.UserName,
                IsActivated=true
            };

            IdentityResult identityResult =await _userManager.CreateAsync(newUser, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(newUser,"Member");
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        #region Create Role
        //public async Task CreateRole()
        //{
        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

        //    if (!await _roleManager.RoleExistsAsync("Member"))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
        //}
        #endregion

    }
}