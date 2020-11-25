using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
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

        public int FilmId { get; set; }
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
        public int? RealisateurId { get; set; }
        public int? ProducteurId { get; set; }
        public string Xtra { get; set; }

        public Categories CategorieNavigation { get; set; }
        public Formats FormatNavigation { get; set; }
        public Producteurs ProducteurNavigationId { get; set; }
        public Realisateurs RealisateurNavigationId { get; set; }
        public Utilisateurs UtilisateurMajNavigationId { get; set; }
        public ICollection<FilmsActeurs> FilmsActeurs { get; set; }
        public ICollection<FilmsLangues> FilmsLangues { get; set; }
        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
        public ICollection<FilmsSupplements> FilmsSupplements { get; set; }
    }
}
