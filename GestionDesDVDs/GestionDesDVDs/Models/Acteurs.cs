using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDesDVDs.Models
{
    public partial class Acteurs
    {
        public Acteurs()
        {
            FilmsActeurs = new HashSet<FilmsActeurs>();
        }

        [Key]
        public int NoActeur { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }

        public ICollection<FilmsActeurs> FilmsActeurs { get; set; }
    }
}
