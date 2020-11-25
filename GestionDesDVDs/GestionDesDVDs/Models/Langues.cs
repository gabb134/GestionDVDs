using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class Langues
    {
        public Langues()
        {
            FilmsLangues = new HashSet<FilmsLangues>();
        }
        [Key]
        public int NoLangue { get; set; }
        public string Langue { get; set; }

        public ICollection<FilmsLangues> FilmsLangues { get; set; }
    }
}
