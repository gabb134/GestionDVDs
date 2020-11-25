using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class Exemplaires
    {
        [Key]
        public int ExemplaireId { get; set; }
        public int UtilisateurProprietaireId { get; set; }

        public Utilisateurs NoUtilisateurProprietaireNavigation { get; set; }
    }
}
