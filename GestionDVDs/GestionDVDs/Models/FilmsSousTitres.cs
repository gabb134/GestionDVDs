using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDVDs.Models
{
    public partial class FilmsSousTitres
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int FilmId { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int SousTitreId { get; set; }

        public Films Film { get; set; }
        public SousTitres SousTitre { get; set; }
    }
}
