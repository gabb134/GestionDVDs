using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsSupplements
    {
        [Key]
        public int FilmId { get; set; }
        public int SupplementId { get; set; }

        public Films FilmNavigationId { get; set; }
        public Supplements SupplementNavigationId { get; set; }
    }
}
