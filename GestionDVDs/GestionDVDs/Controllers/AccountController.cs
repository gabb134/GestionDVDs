using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionDVDs.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly BDW56_424rContext _context;
        public AccountController(BDW56_424rContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
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
                var user = new ApplicationUser
                { 
                    
                    UserName= model.UserName,
                    Email = model.Email,
                    
                };
                
                // Store user data in AspNetUsersdatabasetable
                var result = await userManager.CreateAsync(user, model.Password);
               
                // If user is successfully created, sign-in the user using. SignInManagerand redirect to index action of HomeController
                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(user, isPersistent: false); 
                    var preferences1 = new UtilisateursPreferences
                {
                    UtilisateurId = user.Id,
                    PreferenceId = 1,
                    Valeur = "Bleu"
                }; _context.Add(preferences1);
                    var preferences2 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 2,
                        Valeur = "Noir"
                    };_context.Add(preferences2);
                    var preferences3 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 3,
                        Valeur = "Oui"
                    }; _context.Add(preferences3);
                    var preferences4 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 4,
                        Valeur = "Oui"
                    }; _context.Add(preferences4);
                    var preferences5 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 5,
                        Valeur = "Oui"
                    }; _context.Add(preferences5);
                    var preferences6 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 6,
                        Valeur = "~/background/default.jpg"
                    }; _context.Add(preferences6);
                    var preferences7 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 7,
                        Valeur = "12"
                    }; _context.Add(preferences7);

                    await _context.SaveChangesAsync();

                    if (signInManager.IsSignedIn(User) && User.IsInRole("Administrateur"))
                        return RedirectToAction("ListUsers", "Account");
                    
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
                model.UserName, model.Password, false,false);
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


        /*
         *      Fonctions pour GESTION DES UTILISATEURS
         */

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = userManager.Users.OrderBy(user => user.UserName);

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);

            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await userManager.GetRolesAsync(user);
            ViewData["Roles"] = new SelectList(_context.Roles, "Id", "Name");

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Roles = userRoles
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                    return RedirectToAction("ListUsers");

                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);

                return View(model);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            else if (user.UserName == "admin")
            {
                ViewData["LOL"] = "HAHAHA";
                return RedirectToAction("Contact", "Home");
            }
            else if (user.UserName == User.Identity.Name)
            {
                ViewData["LOL"] = "HAHAHAv2";
                return RedirectToAction("Contact", "Home");
            }
            else
            {
                try
                {
                    var listePreferences = from preference in _context.UtilisateursPreferences
                                           where preference.UtilisateurId == id
                                           select preference;

                    foreach (var preference in listePreferences)
                        _context.UtilisateursPreferences.Remove(preference);

                    _context.SaveChanges();

                    var result = await userManager.DeleteAsync(user);

                    if (result.Succeeded)
                        return RedirectToAction("ListUsers");

                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }

                return View("ListUsers");
            }
        }

    }
}
