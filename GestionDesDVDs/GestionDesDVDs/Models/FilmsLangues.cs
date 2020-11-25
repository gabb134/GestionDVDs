using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class FilmsLangues
    {
        [Key]
        public int NoFilm { get; set; }
        public int NoLangue { get; set; }

        public Films NoFilmNavigation { get; set; }
        public Langues NoLangueNavigation { get; set; }
    }
}
