using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class EmpruntsFilms
    {
        public int ExemplaireId { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateEmprunt { get; set; }

        public Utilisateurs NoUtilisateurNavigation { get; set; }
    }
}
