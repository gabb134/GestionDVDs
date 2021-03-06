﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel;

namespace GestionDVDs.Models
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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int FilmId { get; set; }
        public int? AnneeSortie { get; set; }
        public int? Categorie { get; set; }
        public int? Format { get; set; }
        [Required]
        public DateTime DateMaj { get; set; } = DateTime.Now;
        [Required]
        public string UtilisateurMajId { get; set; } 
        public string Resume { get; set; }
        public int? DureeMinutes { get; set; }
        public int? FilmOriginal { get; set; }
        public string ImagePochette { get; set; }
        public int? NbDisques { get; set; }
        [Required(ErrorMessage ="Veuillez ajouter le titre du film.")]
        public string TitreFrancais { get; set; }
        public string TitreOriginal { get; set; }
        public bool? VersionEtendue { get; set; }
        public int? RealisateurId { get; set; }
        public int? ProducteurId { get; set; }
        [Required(ErrorMessage ="Veuillez ajouter une reference ")]
        public string Xtra { get; set; }

        public Categories CategorieNavigation { get; set; }
        public Formats FormatNavigation { get; set; }
        public Producteurs Producteur { get; set; }
        public Realisateurs Realisateur { get; set; }
        public ApplicationUser UtilisateurMaj { get; set; }
        public ICollection<FilmsActeurs> FilmsActeurs { get; set; }
        public ICollection<FilmsLangues> FilmsLangues { get; set; }
        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
        public ICollection<FilmsSupplements> FilmsSupplements { get; set; }
    }
}
