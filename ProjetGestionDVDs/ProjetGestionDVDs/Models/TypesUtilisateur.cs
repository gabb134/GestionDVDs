using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class TypesUtilisateur
    {
        public TypesUtilisateur()
        {
            Utilisateurs = new HashSet<Utilisateurs>();
        }
        [Key]
        public string TypeUtilisateurId { get; set; }
        public string Description { get; set; }

        public ICollection<Utilisateurs> Utilisateurs { get; set; }
    }
}
