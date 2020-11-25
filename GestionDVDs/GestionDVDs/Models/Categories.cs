using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Films = new HashSet<Films>();
        }
        [Key]
        public int CategorieId { get; set; }
        public string Description { get; set; }

        public ICollection<Films> Films { get; set; }
    }
}
