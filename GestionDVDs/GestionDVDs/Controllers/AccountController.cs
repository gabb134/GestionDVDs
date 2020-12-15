using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;

namespace GestionDVDs.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly BDW56_424rContext _context;

        private string connString = "Server=tcp:424sql.cgodin.qc.ca,5433;Database=BDW56_424r;Trusted_Connection=True;User ID=W56equipe424r; Password=Secret36512;Integrated Security=false";

        public AccountController(BDW56_424rContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
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
                        Valeur = "Cyan"
                    }; _context.Add(preferences1);
                    var preferences2 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 2,
                        Valeur = "Black"
                    };_context.Add(preferences2);
                    var preferences3 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 3,
                        Valeur = "True"
                    }; _context.Add(preferences3);
                    var preferences4 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 4,
                        Valeur = "True"
                    }; _context.Add(preferences4);
                    var preferences5 = new UtilisateursPreferences
                    {
                        UtilisateurId = user.Id,
                        PreferenceId = 5,
                        Valeur = "True"
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

                    using (SqlConnection con = new SqlConnection(connString))
                    {
                        con.Open();
                        string requete = "INSERT INTO AspNetUserRoles values ('" + user.Id + "', 'U')";
                        SqlCommand com = new SqlCommand(requete, con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    
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

            TempData["CouleurFond"] = null;
            TempData["CouleurText"] = null;
            TempData["EnvoiCourrielAjout"] = null;
            TempData["EnvoiCourrielApprobation"] = null;
            TempData["EnvoiCourrielSuppression"] = null;
            TempData["ImageFond"] = null;
            TempData["NbFilmsParPage"] = null;

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
            
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string requete = "SELECT RoleId FROM AspNetUserRoles WHERE UserId = '" + Id + "'";
                SqlCommand com = new SqlCommand(requete, con);
                ViewData["Roles"] = com.ExecuteScalar().ToString();
                con.Close();
            }

            var userRoles = await userManager.GetRolesAsync(user);

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

                    var listeEmprunts = from emprunt in _context.EmpruntsFilms
                                        where emprunt.UtilisateurId == id
                                        select emprunt;
                    foreach (var emprunt in listeEmprunts)
                        _context.EmpruntsFilms.Remove(emprunt);
                    

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


        /*
         *      Fonctions pour GESTION DES ROLES
         */


        [HttpPost]
        public async Task<IActionResult> ChangerRole(String id)
        {
            var role = "N/A";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string requete = "SELECT RoleId FROM AspNetUserRoles WHERE UserId = '" + id + "'";
                SqlCommand com = new SqlCommand(requete, con);
                role = com.ExecuteScalar().ToString();
                con.Close();
            }

            string requete2 = "";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                if (role == "S")
                    requete2 = "UPDATE AspNetUserRoles SET RoleId = 'U' WHERE UserId = '" + id + "'";
                else if (role == "U")
                    requete2 = "UPDATE AspNetUserRoles SET RoleId = 'S' WHERE UserId = '" + id + "'";
                else if (role == "A")
                    return RedirectToAction("Contact", "Home");

                SqlCommand com = new SqlCommand(requete2, con);
                com.ExecuteNonQuery();
                con.Close();
            }

            return RedirectToAction("ListUsers");
        }

    }
}
