using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Controllers;
using WebApplication2.Models;
using WebApplication2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DLL.Models;
using BLL.DTOModels;
using BLL.Interfaces;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IApplicationUserService userService;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IApplicationUserService userService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.userService = userService; 
        }
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser user = new()
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Address = "",
                    FirstName = "",
                    LastName = ""
                };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Client");

                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        return BadRequest("Invalid login attempt");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                return BadRequest("Invalid login attempt");
            }
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    var user = await userManager.FindByNameAsync(model.UserName);
                    var roles = await userManager.GetRolesAsync(user);

                    return Json(new { role = roles.FirstOrDefault() });
                }
                else
                {
                    return BadRequest("Неверное имя пользователя или пароль.");
                }
            }
            else
            {
                return BadRequest("Неверное имя пользователя или пароль.");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfile(ApplicationUserDto updatedUserData)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await userManager.GetUserAsync(User);

                currentUser.FirstName = updatedUserData.FirstName;
                currentUser.LastName = updatedUserData.LastName;
                currentUser.Address = updatedUserData.Address;

                var result = await userManager.UpdateAsync(currentUser);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserProfile", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View("EditProfile", updatedUserData);
                }
            }
            else
            {
                return View("EditProfile", updatedUserData);
            }
        }


        [AllowAnonymous]
        [HttpGet("/Account/Logout")]
        public async Task<ActionResult> LogOut()
        {
            try
            {
                await signInManager.SignOutAsync();
            }
            catch { }
            return RedirectToAction("Index", "Home");
        }
    }
}