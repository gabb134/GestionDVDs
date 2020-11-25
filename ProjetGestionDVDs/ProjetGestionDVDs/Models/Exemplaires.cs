using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Exemplaires
    {
        public int ExemplaireId { get; set; }
        public int UtilisateurProprietaireId { get; set; }

        public Utilisateurs NoUtilisateurProprietaireNavigation { get; set; }
    }
}
