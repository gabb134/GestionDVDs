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
    public class MesDVDsController : Controller
    {
        private readonly BDW56_424rContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MesDVDsController(BDW56_424rContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            string userName = User.Identity.Name;

            var userId = _userManager.GetUserId(User);

            var lstEmprunt = _context.EmpruntsFilms.Where(e => e.UtilisateurId == userId).Select(e => e.ExemplaireId).ToList();

            List<string> lstEmpruntString = lstEmprunt.ConvertAll<string>(i => i.ToString().Substring(0, 6));

            var films = from m in _context.Films
                        select m;

            films = films.Include(f => f.CategorieNavigation).Include(f => f.FormatNavigation).Include(f => f.Producteur).Include(f => f.Realisateur).Include(f => f.UtilisateurMaj)
                .Where(f => lstEmpruntString.Contains(f.FilmId.ToString()));

            // utilisateurs preferences
            var userPreference = from u in _context.UtilisateursPreferences
                                 where u.UtilisateurId == userId && u.PreferenceId == 7
                                 select u.Valeur;

            int itemParPage = 0;

            foreach (var item in userPreference)
            {
                itemParPage = int.Parse(item);
            }



            return View(nameof(Index), await PaginatedList<Films>.CreateAsync(films.AsNoTracking(), 1, Convert.ToInt32(TempData.Peek("NbFilmsParPage"))));
        }
    }
}