using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsActeurs
    {
        public int FilmId { get; set; }
        public int ActeurId { get; set; }

        [Key]
        public Acteurs ActeurNavigationId { get; set; }
        public Films FilmNavigationId { get; set; }
    }
}
