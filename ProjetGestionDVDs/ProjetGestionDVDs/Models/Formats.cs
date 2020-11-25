using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Formats
    {
        public Formats()
        {
            Films = new HashSet<Films>();
        }

        public int FormatId { get; set; }
        public string Description { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
