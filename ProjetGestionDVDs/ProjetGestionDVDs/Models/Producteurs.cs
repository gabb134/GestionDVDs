using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Producteurs
    {
        public Producteurs()
        {
            Films = new HashSet<Films>();
        }

        public int ProducteurId { get; set; }
        public string Nom { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
