using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class SousTitres
    {
        public SousTitres()
        {
            FilmsSousTitres = new HashSet<FilmsSousTitres>();
        }

        public int SousTitreId { get; set; }
        public string LangueSousTitre { get; set; }

        public ICollection<FilmsSousTitres> FilmsSousTitres { get; set; }
    }
}
