using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionDVDs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace GestionDVDs.Controllers
{
    public class FilmsController : Controller
    {
        private readonly BDW56_424rContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FilmsController(BDW56_424rContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Films
        /*  public async Task<IActionResult> Index()
          {
               var bDW56_424rContext = _context.Films.Include(f => f.CategorieNavigation).Include(f => f.FormatNavigation).Include(f => f.Producteur).Include(f => f.Realisateur).Include(f => f.UtilisateurMaj);
               return View(await bDW56_424rContext.ToListAsync());

          }*/
        [Authorize]
    
        public async Task<IActionResult> Index(string searchString, string sortOrder, string currentFilter, int? pageNumber, string autreUtilisateur)
        {
            //Pagination
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;


            var films = from m in _context.Films
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                films = films.Where(s => s.TitreFrancais.Contains(searchString) || s.TitreOriginal.Contains(searchString)).Include(f => f.CategorieNavigation).Include(f => f.FormatNavigation).Include(f => f.Producteur).Include(f => f.Realisateur).Include(f => f.UtilisateurMaj); ;

            }
            switch (sortOrder)
            {
                case "name_desc":
                    films = films.OrderBy(s => s.TitreFrancais);
                    break;
                case "Date":
                    films = films.OrderBy(s => s.AnneeSortie);
                    break;
                case "date_desc":
                    films = films.OrderByDescending(s => s.AnneeSortie);
                    break;
                default:
                    films = films.OrderBy(s => s.TitreFrancais);
                    break;
            }


            // user qui est connecté
            string userName = User.Identity.Name;

            var userId = _context.ApplicationUser.Where(u => u.UserName == userName).Select(u => u.Id).First();

            // utilisateurs preferences
            var userColor = from u in _context.UtilisateursPreferences
                            where u.UtilisateurId == userId && u.PreferenceId == 1
                            select u.Valeur;
            var userTextColor = from u in _context.UtilisateursPreferences
                            where u.UtilisateurId == userId && u.PreferenceId == 2
                            select u.Valeur;
            var userPreference = from u in _context.UtilisateursPreferences
                                 where u.UtilisateurId == userId && u.PreferenceId == 7
                                 select u.Valeur;
            string couleurTexte = "";
            foreach (var item in userTextColor)
            {
                couleurTexte = item.ToString();
            }
            string couleurFond = "";
            foreach (var item in userColor)
            {
                couleurFond = item.ToString();
            }
            if (couleurFond == "Blue")
                ViewData["CouleurFond"] = "blue";
            int itemParPage = 0;

           foreach(var item in userPreference)
            {
                itemParPage = int.Parse(item);
            }
                               
                                    


            return View(await PaginatedList<Films>.CreateAsync(films.AsNoTracking(), pageNumber ?? 1, itemParPage));
        }

        // GET: Films/Details/5
        [Authorize]
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
        [Authorize]
        public IActionResult Create()
        {
            /*var filmId = (DateTime.Now.Year.ToString().Substring(2)) + (DateTime.Now.Month.ToString());
            var films = from film in _context.Films
                        where film.FilmId.ToString().Substring(0,4) == filmId
                        select film;

            var filmCount = (films.Count() + 1).ToString().PadLeft(2, '0');
            filmId += filmCount; */

            ViewData["FilmId"] = createFilmId();
            ViewData["UtilisateurMajId"] = _userManager.GetUserId(User);

            ViewData["Categorie"] = new SelectList(_context.Categories, "CategorieId", "Description");
            ViewData["Format"] = new SelectList(_context.Formats, "FormatId", "Description");
            ViewData["ProducteurId"] = new SelectList(_context.Producteurs, "ProducteurId", "Nom");
            ViewData["RealisateurId"] = new SelectList(_context.Realisateurs, "RealisateurId", "Nom");
          //  ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel");
            return View();
        }

        // GET: Film/CreateBulk
        [Authorize]
        [HttpGet]
        public IActionResult CreateBulk()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmId,AnneeSortie,Categorie,Format,DateMaj,UtilisateurMajId,Resume,DureeMinutes,FilmOriginal,ImagePochette,NbDisques,TitreFrancais,TitreOriginal,VersionEtendue,RealisateurId,ProducteurId,Xtra")] Films films)
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
           // ViewData["UtilisateurMajid"] = new SelectList(_context.Utilisateurs, "UtilisateurId", "Courriel", films.UtilisateurMajId);
            return View(films);
        }

        // POST: Film/CreateBulk
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBulk(FilmCourt model)
        {
            string userId = _userManager.GetUserId(User);
            DateTime dateNow = DateTime.Now;
            string xtra = "Ce film a été ajouté en mode abrégé.";
            // f1
            if (model.Titre1 != null) {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre1,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f2
            if (model.Titre2 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre2,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f3
            if (model.Titre3 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre3,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f4
            if (model.Titre4 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre4,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f5
            if (model.Titre5 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre5,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f6
            if (model.Titre6 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre6,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f7
            if (model.Titre7 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre7,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f8
            if (model.Titre8 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre8,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f9
            if (model.Titre9 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre9,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }// f10
            if (model.Titre10 != null)
            {
                var film = new Films
                {
                    FilmId = int.Parse(createFilmId()),
                    TitreFrancais = model.Titre10,
                    DateMaj = dateNow,
                    UtilisateurMajId = userId,
                    Xtra = xtra,
                };
                _context.Add(film);
                await _context.SaveChangesAsync();
            }
            

            return RedirectToAction("Index");
        }


        public String createFilmId()
        {
            var filmId = (DateTime.Now.Year.ToString().Substring(2)) + (DateTime.Now.Month.ToString());
            var films = from film in _context.Films
                        where film.FilmId.ToString().Substring(0, 4) == filmId
                        select film;

            var filmCount = (films.Count() + 1).ToString().PadLeft(2, '0');
            filmId += filmCount;

            return filmId;
        }


        // GET: Films/Edit/5
        [Authorize]
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
            return View(films);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
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
            return View(films);
        }

        // GET: Films/Delete/5
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> MesDVDs()
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



            return View(nameof(Index), await PaginatedList<Films>.CreateAsync(films.AsNoTracking(), 1, itemParPage));
        }

    }
}
