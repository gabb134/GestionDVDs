using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Formats
    {
        public Formats()
        {
            Films = new HashSet<Films>();
        }
        [Key]
        public int FormatId { get; set; }
        public string Description { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
