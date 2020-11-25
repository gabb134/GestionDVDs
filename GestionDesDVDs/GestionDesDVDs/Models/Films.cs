using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class Films
    {
        public Films()
        {
            FilmsActeurs = new HashSet<FilmsActeurs>();
            FilmsLangues = new HashSet<FilmsLangues>();
            FilmsSousTitres = new HashSet<FilmsSousTitres>();
            FilmsSupplements = new HashSet<FilmsSupplements>();
        }
        [Key]
        public int NoFilm { get; set; }
        public int? AnneeSortie { get; set; }
        public int? Categorie { get; set; }
        public int? Format { get; set; }
        public DateTime DateMaj { get; set; }
        public int NoUtilisateurMaj { get; set; }
        public string Resume { get; set; }
        public int? DureeMinutes { get; set; }
        public int? FilmOriginal { get; set; }
        public string ImagePochette { get; set; }
        public int? NbDisques { get; set; }
        public string TitreFrancais { get; set; }
        public string TitreOriginal { get; set; }
        public bool? VersionEtendue { get; set; }
        public int? NoRealisateur { get; set; }
        public int? NoProducteur { get; set; }
        public string Xtra { get; set; }

        public Categories CategorieNavigation { get; set; }
        public Formats FormatNavigation { get; set; }
        public Producteurs NoProducteurNavigation { get; set; }
        public Realisateurs NoRealisateurNavigation { get; set; }
        public Utilisateurs NoUtilisateurMajNavigation { get; set; }
        public ICollection<FilmsActeurs> FilmsActeurs { get; set; }
        public ICollection<FilmsLangues> FilmsLangues { get; set; }
        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
        public ICollection<FilmsSupplements> FilmsSupplements { get; set; }
    }
}
