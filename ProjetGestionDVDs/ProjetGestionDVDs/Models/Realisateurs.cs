using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Realisateurs
    {
        public Realisateurs()
        {
            Films = new HashSet<Films>();
        }

        public int RealisateurId { get; set; }
        public string Nom { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
