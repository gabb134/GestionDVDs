using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class FilmsActeurs
    {
        [Key]
        public int NoFilm { get; set; }
        public int NoActeur { get; set; }

        public Acteurs NoActeurNavigation { get; set; }
        public Films NoFilmNavigation { get; set; }
    }
}
