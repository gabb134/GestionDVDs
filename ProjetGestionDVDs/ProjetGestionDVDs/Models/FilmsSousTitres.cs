using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsSousTitres
    {
        public int FilmId { get; set; }
        public int SousTitreId { get; set; }

        public Films FilmNavigationId { get; set; }
        public SousTitres SousTitreNavigationId { get; set; }
    }
}
