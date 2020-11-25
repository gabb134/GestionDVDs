using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsLangues
    {
        public int FilmId { get; set; }
        public int LangueId { get; set; }

        public Films FilmNavigationId { get; set; }
        public Langues LangueNavigationId { get; set; }
    }
}
