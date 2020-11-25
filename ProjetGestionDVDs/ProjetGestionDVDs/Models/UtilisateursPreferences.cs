using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class UtilisateursPreferences
    {
        public int UtilisateurId { get; set; }
        public int PreferenceId { get; set; }
        public string Valeur { get; set; }

        public Preferences NoPreferenceNavigation { get; set; }
        public Utilisateurs NoUtilisateurNavigation { get; set; }
    }
}
