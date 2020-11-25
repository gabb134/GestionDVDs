using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Realisateurs
    {
        public Realisateurs()
        {
            Films = new HashSet<Films>();
        }
        [Key]
        public int RealisateurId { get; set; }
        public string Nom { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
