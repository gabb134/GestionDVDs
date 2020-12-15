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
                    new SelectListItem{ Text="Cyan", Value = "cyan",  Selected = true},
                    new SelectListItem{ Text="Vert", Value = "Green" },
                    new SelectListItem{ Text="Jaune", Value = "Yellow" },
                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCouleursFond;
            }
            else if (id == "2")
            {
                var listeCouleursTexte = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Noir", Value = "Black"},
                    new SelectListItem{ Text="Bleu", Value = "Blue" },
                    new SelectListItem{ Text="Vert", Value = "Green" },
                    new SelectListItem{ Text="Jaune", Value = "Yellow" },
                 };
                ViewData["Chiffres"] = "";
                ViewData["valide"] = "true";
                ViewData["Liste"] = listeCouleursTexte;
            }
            else if (id == "3" || id == "4" || id == "5")
            {
                var listeCourriel = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Oui", Value = "true"},
                    new SelectListItem{ Text="Non", Value = "false" },

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


                    string userName = User.Identity.Name;
                    var userId = _context.ApplicationUser.Where(u => u.UserName == userName).Select(u => u.Id).First();
                    var userColor = (from u in _context.UtilisateursPreferences
                                     where u.UtilisateurId == userId && u.PreferenceId == 1
                                     select u.Valeur).ToList();
                    var userTextColor = (from u in _context.UtilisateursPreferences
                                         where u.UtilisateurId == userId && u.PreferenceId == 2
                                         select u.Valeur).ToList();
                    var userEmailAdd = (from u in _context.UtilisateursPreferences
                                        where u.UtilisateurId == userId && u.PreferenceId == 3
                                        select u.Valeur).ToList();
                    var userEmailApp = (from u in _context.UtilisateursPreferences
                                        where u.UtilisateurId == userId && u.PreferenceId == 4
                                        select u.Valeur).ToList();
                    var userEmailDel = (from u in _context.UtilisateursPreferences
                                        where u.UtilisateurId == userId && u.PreferenceId == 5
                                        select u.Valeur).ToList();
                    var userImageBack = (from u in _context.UtilisateursPreferences
                                         where u.UtilisateurId == userId && u.PreferenceId == 6
                                         select u.Valeur).ToList();
                    var userPreference = (from u in _context.UtilisateursPreferences
                                          where u.UtilisateurId == userId && u.PreferenceId == 7
                                          select u.Valeur).ToList();

                    TempData["CouleurFond"] = userColor[0];
                    TempData["CouleurText"] = userTextColor[0];
                    TempData["EnvoiCourrielAjout"] = userEmailAdd[0];
                    TempData["EnvoiCourrielApprobation"] = userEmailApp[0];
                    TempData["EnvoiCourrielSuppression"] = userEmailDel[0];
                    TempData["ImageFond"] = userImageBack[0];
                    TempData["NbFilmsParPage"] = userPreference[0];
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
