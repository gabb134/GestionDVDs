using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Supplements
    {
        public Supplements()
        {
            FilmsSupplements = new HashSet<FilmsSupplements>();
        }

        public int SupplementId { get; set; }
        public string Description { get; set; }

        public ICollection<FilmsSupplements> FilmsSupplements { get; set; }
    }
}
