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
