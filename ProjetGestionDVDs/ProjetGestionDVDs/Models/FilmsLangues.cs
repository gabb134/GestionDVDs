using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsLangues
    {
        [Key]
        public int FilmId { get; set; }
        public int LangueId { get; set; }

        public Films FilmNavigationId { get; set; }
        public Langues LangueNavigationId { get; set; }
    }
}
