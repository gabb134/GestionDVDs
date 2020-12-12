using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Authorization;

namespace GestionDVDs.Controllers
{
    public class UtilisateursPreferencesController : Controller
    {
        private readonly BDW56_424rContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public UtilisateursPreferencesController(BDW56_424rContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: UtilisateursPreferences
        [Authorize]
        public async Task<IActionResult> Index()
        {
            string userName = User.Identity.Name;
            var userId = _context.ApplicationUser.Where(u => u.UserName == userName).Select(u => u.Id).First();
            var bDW56_424rContext = _context.UtilisateursPreferences.Include(u => u.Preference).Include(u => u.Utilisateur).Where(u => u.Utilisateur.Id == userId.ToString());
            return View(await bDW56_424rContext.ToListAsync());
        }

        // GET: UtilisateursPreferences/Details/5
        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilisateursPreferences = await _context.UtilisateursPreferences
                .Include(u => u.Preference)
                .Include(u => u.Utilisateur)
                .FirstOrDefaultAsync(m => m.UtilisateurId == id);
            if (utilisateursPreferences == null)
            {
                return NotFound();
            }

            return View(utilisateursPreferences);
        }

        // GET: UtilisateursPreferences/Create
        [Authorize]
        public IActionResult Create()
        {
            string userName = User.Identity.Name;
            var userId = _context.ApplicationUser.Where(u => u.UserName == userName).Select(u => u.Id).First();
            ViewData["PreferenceId"] = new SelectList(_context.Preferences, "PreferenceId", "Description");
            ViewData["UtilisateurId"] = userId;
            return View();
        }

        // POST: UtilisateursPreferences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UtilisateurId,PreferenceId,Valeur")] UtilisateursPreferences utilisateursPreferences)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilisateursPreferences);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PreferenceId"] = new SelectList(_context.Preferences, "PreferenceId", "Description", utilisateursPreferences.PreferenceId);
            ViewData["UtilisateurId"] = new SelectList(_context.ApplicationUser, "Id", "Id", utilisateursPreferences.UtilisateurId);
            return View(utilisateursPreferences);
        }

        // GET: UtilisateursPreferences/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string userName = User.Identity.Name;
            var userId = _context.ApplicationUser.Where(u => u.UserName == userName).Select(u => u.Id).First();
            var utilisateursPreferences = await _context.UtilisateursPreferences.FindAsync(userId.ToString(),Int32.Parse(id));
            if (utilisateursPreferences == null)
            {
                return NotFound();
            };
            if (id == "1")
            {
                var listeCouleursFond = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Bleu", Value = "Bleu",  Selected = true},
                    new SelectListItem{ Text="Vert", Value = "Vert" },
                    new SelectListItem{ Text="Jaune", Value = "Jaune" },
                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCouleursFond;
            }
            else if (id == "2")
            {
                var listeCouleursTexte = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Noir", Value = "Noir"},
                    new SelectListItem{ Text="Bleu", Value = "Bleu" },
                    new SelectListItem{ Text="Vert", Value = "Vert" },
                    new SelectListItem{ Text="Jaune", Value = "Jaune" },
                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCouleursTexte;
            }
            else if (id == "3" || id == "4" || id == "5")
            {
                var listeCourriel = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Oui", Value = "Oui"},
                    new SelectListItem{ Text="Non", Value = "Non" },

                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCourriel;
            }
            else if (id == "6")
            {
                var listeCouleursTexte = new List<SelectListItem>
                {
                    new SelectListItem{ Text="~/background/default.jpg", Value = "~/background/default.jpg"},

                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCouleursTexte;
            }
            else if (id == "7")
            {
                
                
                ViewData["valide"] = "false";
                ViewData["Chiffres"] = "<input  asp-for=\"Valeur\" id=\"Valeur\" name=\"Valeur\"  type=\"number\"   min=\"6\" max=\"99\" class = \"form - control\">";
            }
            ViewData["PreferenceId"] = new SelectList(_context.Preferences, "PreferenceId", "Description", utilisateursPreferences.PreferenceId);
            ViewData["UtilisateurId"] = new SelectList(_context.ApplicationUser, "Id", "Id", utilisateursPreferences.UtilisateurId);
            return View(utilisateursPreferences);
        }

        // POST: UtilisateursPreferences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UtilisateurId,PreferenceId,Valeur")] UtilisateursPreferences utilisateursPreferences)
        {
            /* if (id != utilisateursPreferences.UtilisateurId)
             {
                 return NotFound();
             }*/
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilisateursPreferences);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilisateursPreferencesExists(utilisateursPreferences.UtilisateurId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PreferenceId"] = new SelectList(_context.Preferences, "PreferenceId", "Description", utilisateursPreferences.PreferenceId);
            ViewData["UtilisateurId"] = new SelectList(_context.ApplicationUser, "Id", "Id", utilisateursPreferences.UtilisateurId);
            return View(utilisateursPreferences);
        }

        // GET: UtilisateursPreferences/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilisateursPreferences = await _context.UtilisateursPreferences
                .Include(u => u.Preference)
                .Include(u => u.Utilisateur)
                .FirstOrDefaultAsync(m => m.UtilisateurId == id);
            if (utilisateursPreferences == null)
            {
                return NotFound();
            }

            return View(utilisateursPreferences);
        }

        // POST: UtilisateursPreferences/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var utilisateursPreferences = await _context.UtilisateursPreferences.FindAsync(id);
            _context.UtilisateursPreferences.Remove(utilisateursPreferences);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilisateursPreferencesExists(string id)
        {
            return _context.UtilisateursPreferences.Any(e => e.UtilisateurId == id);
        }
    }
}
