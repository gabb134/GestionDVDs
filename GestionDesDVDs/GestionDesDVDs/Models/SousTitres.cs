using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class SousTitres
    {
        public SousTitres()
        {
            FilmsSousTitres = new HashSet<FilmsSousTitres>();
        }
        [Key]
        public int NoSousTitre { get; set; }
        public string LangueSousTitre { get; set; }

        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
    }
}
