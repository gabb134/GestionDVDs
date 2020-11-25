using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class EmpruntsFilms
    {
        [Key]
        public int ExemplaireId { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateEmprunt { get; set; }

        public Utilisateurs NoUtilisateurNavigation { get; set; }
    }
}
