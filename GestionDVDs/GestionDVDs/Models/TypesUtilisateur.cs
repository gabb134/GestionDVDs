using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class TypesUtilisateur
    {
        public TypesUtilisateur()
        {
            Utilisateurs = new HashSet<Utilisateurs>();
        }
        [Key]
        public char TypeUtilisateur { get; set; }
        public string Description { get; set; }

        public ICollection<Utilisateurs> Utilisateurs { get; set; }
    }
}
