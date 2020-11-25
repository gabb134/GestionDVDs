using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Langues
    {
        public Langues()
        {
            FilmsLangues = new HashSet<FilmsLangues>();
        }

        public int LangueId { get; set; }
        public string Langue { get; set; }

        public ICollection<FilmsLangues> FilmsLangues { get; set; }
    }
}
