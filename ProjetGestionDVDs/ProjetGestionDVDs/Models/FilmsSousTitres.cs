using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class FilmsSousTitres
    {
        [Key]
        public int FilmId { get; set; }
        public int SousTitreId { get; set; }

        public Films FilmNavigationId { get; set; }
        public SousTitres SousTitreNavigationId { get; set; }
    }
}
