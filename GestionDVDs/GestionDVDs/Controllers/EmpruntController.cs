using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDVDs.Controllers
{
    public class EmpruntController : Controller
    {
        private readonly BDW56_424rContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmpruntController(BDW56_424rContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Emprunt
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet] // [HttpPost] ne retourne aucune info
        //[ValidateAntiForgeryToken]  plante si activé
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .Include(f => f.CategorieNavigation)
                .Include(f => f.FormatNavigation)
                .Include(f => f.Producteur)
                .Include(f => f.Realisateur)
                .Include(f => f.UtilisateurMaj)
                .FirstOrDefaultAsync(m => m.FilmId == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Emprunter(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films.FindAsync(id);

            var idEmprunt = Convert.ToInt32(id.ToString() + "01");

            var emprunt = await _context.EmpruntsFilms.FindAsync(idEmprunt);

            if (films == null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(emprunt);

                EmpruntsFilms nouvelEmprunt = new EmpruntsFilms { ExemplaireId = idEmprunt, UtilisateurId = _userManager.GetUserId(User), DateEmprunt = DateTime.Now };

                _context.Add(nouvelEmprunt);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("MesDVDs", "Films", films);
        }

        /*
        // GET: Emprunt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emprunt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emprunt/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emprunt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emprunt/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emprunt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emprunt/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        */
    }
}