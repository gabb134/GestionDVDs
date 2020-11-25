using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionDVDs.Models;

namespace GestionDVDs.Controllers
{
    public class FilmsController : Controller
    {
        private readonly BDW56_424rContext _context;

        public FilmsController(BDW56_424rContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index()
        {
            var bDW56_424rContext = _context.Films.Include(f => f.CategorieNavigation).Include(f => f.FormatNavigation).Include(f => f.Producteur).Include(f => f.Realisateur).Include(f => f.UtilisateurMaj);
            return View(await bDW56_424rContext.ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .Include(f => f.CategorieNavigation)
                .Include(f => f.FormatNavigation)
                .Include(f => f.Producteur)
                .Include(f => f.Realisateur)
                .Include(f => f.UtilisateurMaj)
                .FirstOrDefaultAsync(m => m.FilmId == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            ViewData["Categorie"] = new SelectList(_context.Categories, "CategorieId", "Description");
            ViewData["Format"] = new SelectList(_context.Formats, "FormatId", "Description");
            ViewData["ProducteurId"] = new SelectList(_context.Producteurs, "ProducteurId", "Nom");
            ViewData["RealisateurId"] = new SelectList(_context.Realisateurs, "RealisateurId", "Nom");
            ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmId,AnneeSortie,Categorie,Format,DateMaj,UtilisateurMajid,Resume,DureeMinutes,FilmOriginal,ImagePochette,NbDisques,TitreFrancais,TitreOriginal,VersionEtendue,RealisateurId,ProducteurId,Xtra")] Films films)
        {
            if (ModelState.IsValid)
            {
                _context.Add(films);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categorie"] = new SelectList(_context.Categories, "CategorieId", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "FormatId", "Description", films.Format);
            ViewData["ProducteurId"] = new SelectList(_context.Producteurs, "ProducteurId", "Nom", films.ProducteurId);
            ViewData["RealisateurId"] = new SelectList(_context.Realisateurs, "RealisateurId", "Nom", films.RealisateurId);
            ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel", films.UtilisateurMajid);
            return View(films);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films.FindAsync(id);
            if (films == null)
            {
                return NotFound();
            }
            ViewData["Categorie"] = new SelectList(_context.Categories, "CategorieId", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "FormatId", "Description", films.Format);
            ViewData["ProducteurId"] = new SelectList(_context.Producteurs, "ProducteurId", "Nom", films.ProducteurId);
            ViewData["RealisateurId"] = new SelectList(_context.Realisateurs, "RealisateurId", "Nom", films.RealisateurId);
            ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel", films.UtilisateurMajid);
            return View(films);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmId,AnneeSortie,Categorie,Format,DateMaj,UtilisateurMajid,Resume,DureeMinutes,FilmOriginal,ImagePochette,NbDisques,TitreFrancais,TitreOriginal,VersionEtendue,RealisateurId,ProducteurId,Xtra")] Films films)
        {
            if (id != films.FilmId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(films);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmsExists(films.FilmId))
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
            ViewData["Categorie"] = new SelectList(_context.Categories, "CategorieId", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "FormatId", "Description", films.Format);
            ViewData["ProducteurId"] = new SelectList(_context.Producteurs, "ProducteurId", "Nom", films.ProducteurId);
            ViewData["RealisateurId"] = new SelectList(_context.Realisateurs, "RealisateurId", "Nom", films.RealisateurId);
            ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel", films.UtilisateurMajid);
            return View(films);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .Include(f => f.CategorieNavigation)
                .Include(f => f.FormatNavigation)
                .Include(f => f.Producteur)
                .Include(f => f.Realisateur)
                .Include(f => f.UtilisateurMaj)
                .FirstOrDefaultAsync(m => m.FilmId == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var films = await _context.Films.FindAsync(id);
            _context.Films.Remove(films);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmsExists(int id)
        {
            return _context.Films.Any(e => e.FilmId == id);
        }
    }
}
