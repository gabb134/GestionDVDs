using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class Langues
    {
        public Langues()
        {
            FilmsLangues = new HashSet<FilmsLangues>();
        }
        [Key]
        public int LangueId { get; set; }
        public string Langue { get; set; }

        public ICollection<FilmsLangues> FilmsLangues { get; set; }
    }
}
