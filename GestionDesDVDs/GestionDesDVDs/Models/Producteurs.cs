using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class Producteurs
    {
        public Producteurs()
        {
            Films = new HashSet<Films>();
        }
        [Key]
        public int NoProducteur { get; set; }
        public string Nom { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
