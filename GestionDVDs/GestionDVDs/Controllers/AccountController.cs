using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GestionDVDs.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new IdentityUser
                { 
                    
                    UserName= model.Email,
                    Email = model.Email,
                    
                };
                // Store user data in AspNetUsersdatabasetable
                var result = await userManager.CreateAsync(user, model.Password);
                // If user is successfully created, sign-in the user using. SignInManagerand redirect to index action of HomeController
                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Login", "Account");
                }
                // If there are any errors, add them to the ModelStateobject. which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                model.Email, model.Password, false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Films");
                }
                ModelState.AddModelError(string.Empty, "Nom d'utilisateur ou mot de passe incorrect");
            }
            return View(model);
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
