using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsActeurs
    {
        public int FilmId { get; set; }
        public int ActeurId { get; set; }

        public Acteurs NoActeurNavigation { get; set; }
        public Films NoFilmNavigation { get; set; }
    }
}
