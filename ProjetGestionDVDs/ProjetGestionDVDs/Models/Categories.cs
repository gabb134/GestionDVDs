using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Films = new HashSet<Films>();
        }

        public int NoCategorie { get; set; }
        public string Description { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
