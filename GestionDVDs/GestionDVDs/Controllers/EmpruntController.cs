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
                if(emprunt != null)
                    _context.Remove(emprunt);

                EmpruntsFilms nouvelEmprunt = new EmpruntsFilms { ExemplaireId = idEmprunt, UtilisateurId = _userManager.GetUserId(User), DateEmprunt = DateTime.Now };

                _context.Add(nouvelEmprunt);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "MesDVDs", films);
        }
    }
}