using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Supplements
    {
        public Supplements()
        {
            FilmsSupplements = new HashSet<FilmsSupplements>();
        }
        [Key]
        public int SupplementId { get; set; }
        public string Description { get; set; }

        public ICollection<FilmsSupplements> FilmsSupplements { get; set; }
    }
}
