using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class UtilisateursPreferences
    {
        [Key]
        public int UtilisateurId { get; set; }
        public int PreferenceId { get; set; }
        public string Valeur { get; set; }

        public Preferences PreferenceNavigationId { get; set; }
        public Utilisateurs UtilisateurNavigationId { get; set; }
    }
}
