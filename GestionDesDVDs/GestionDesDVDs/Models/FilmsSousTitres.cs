using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class FilmsSousTitres
    {
        [Key]
        public int NoFilm { get; set; }
        public int NoSousTitre { get; set; }

        public Films NoFilmNavigation { get; set; }
        public SousTitres NoSousTitreNavigation { get; set; }
    }
}
