﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionDesDVDs.Models;

namespace GestionDesDVDs.Controllers
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
            var bDW56_424rContext = _context.Films.Include(f => f.CategorieNavigation).Include(f => f.FormatNavigation).Include(f => f.NoProducteurNavigation).Include(f => f.NoRealisateurNavigation).Include(f => f.NoUtilisateurMajNavigation);
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
                .Include(f => f.NoProducteurNavigation)
                .Include(f => f.NoRealisateurNavigation)
                .Include(f => f.NoUtilisateurMajNavigation)
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
            ViewData["Categorie"] = new SelectList(_context.Categories, "NoCategorie", "Description");
            ViewData["Format"] = new SelectList(_context.Formats, "NoFormat", "Description");
            ViewData["NoProducteur"] = new SelectList(_context.Producteurs, "NoProducteur", "Nom");
            ViewData["NoRealisateur"] = new SelectList(_context.Realisateurs, "NoRealisateur", "Nom");
            ViewData["NoUtilisateurMaj"] = new SelectList(_context.Utilisateurs, "NoUtilisateur", "Courriel");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmId,AnneeSortie,Categorie,Format,DateMaj,NoUtilisateurMaj,Resume,DureeMinutes,FilmOriginal,ImagePochette,NbDisques,TitreFrancais,TitreOriginal,VersionEtendue,NoRealisateur,NoProducteur,Xtra")] Films films)
        {
            if (ModelState.IsValid)
            {
                _context.Add(films);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categorie"] = new SelectList(_context.Categories, "NoCategorie", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "NoFormat", "Description", films.Format);
            ViewData["NoProducteur"] = new SelectList(_context.Producteurs, "NoProducteur", "Nom", films.NoProducteur);
            ViewData["NoRealisateur"] = new SelectList(_context.Realisateurs, "NoRealisateur", "Nom", films.NoRealisateur);
            ViewData["NoUtilisateurMaj"] = new SelectList(_context.Utilisateurs, "NoUtilisateur", "Courriel", films.NoUtilisateurMaj);
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
            ViewData["Categorie"] = new SelectList(_context.Categories, "NoCategorie", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "NoFormat", "Description", films.Format);
            ViewData["NoProducteur"] = new SelectList(_context.Producteurs, "NoProducteur", "Nom", films.NoProducteur);
            ViewData["NoRealisateur"] = new SelectList(_context.Realisateurs, "NoRealisateur", "Nom", films.NoRealisateur);
            ViewData["NoUtilisateurMaj"] = new SelectList(_context.Utilisateurs, "NoUtilisateur", "Courriel", films.NoUtilisateurMaj);
            return View(films);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmId,AnneeSortie,Categorie,Format,DateMaj,NoUtilisateurMaj,Resume,DureeMinutes,FilmOriginal,ImagePochette,NbDisques,TitreFrancais,TitreOriginal,VersionEtendue,NoRealisateur,NoProducteur,Xtra")] Films films)
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
            ViewData["Categorie"] = new SelectList(_context.Categories, "NoCategorie", "Description", films.Categorie);
            ViewData["Format"] = new SelectList(_context.Formats, "NoFormat", "Description", films.Format);
            ViewData["NoProducteur"] = new SelectList(_context.Producteurs, "NoProducteur", "Nom", films.NoProducteur);
            ViewData["NoRealisateur"] = new SelectList(_context.Realisateurs, "NoRealisateur", "Nom", films.NoRealisateur);
            ViewData["NoUtilisateurMaj"] = new SelectList(_context.Utilisateurs, "NoUtilisateur", "Courriel", films.NoUtilisateurMaj);
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
                .Include(f => f.NoProducteurNavigation)
                .Include(f => f.NoRealisateurNavigation)
                .Include(f => f.NoUtilisateurMajNavigation)
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
