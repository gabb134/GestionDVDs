using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDVDs.Models
{
    public partial class FilmsSupplements
    {
        [Key]
        [Column(Order=1)]
        [Required]
        public int FilmId { get; set; }
        [Key]
        [Column(Order =2)]
        public int SupplementId { get; set; }

        public Films Film { get; set; }
        public Supplements Supplement { get; set; }
    }
}
