using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Acteurs
    {
        public Acteurs()
        {
            FilmsActeurs = new HashSet<FilmsActeurs>();
        }
        [Key]
        public int ActeurId { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }

        public ICollection<FilmsActeurs> FilmsActeurs { get; set; }
    }
}
