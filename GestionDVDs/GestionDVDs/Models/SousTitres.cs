using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class SousTitres
    {
        public SousTitres()
        {
            FilmsSousTitres = new HashSet<FilmsSousTitres>();
        }
        [Key]
        public int SousTitreId { get; set; }
        public string LangueSousTitre { get; set; }

        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
    }
}
