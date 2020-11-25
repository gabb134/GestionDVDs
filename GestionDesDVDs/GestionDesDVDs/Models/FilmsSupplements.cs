using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class FilmsSupplements
    {
        [Key]
        public int NoFilm { get; set; }
        public int NoSupplement { get; set; }

        public Films NoFilmNavigation { get; set; }
        public Supplements NoSupplementNavigation { get; set; }
    }
}
