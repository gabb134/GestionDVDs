using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsSupplements
    {
        public int FilmId { get; set; }
        public int SupplementId { get; set; }

        public Films FilmNavigationId { get; set; }
        public Supplements SupplementNavigationId { get; set; }
    }
}
