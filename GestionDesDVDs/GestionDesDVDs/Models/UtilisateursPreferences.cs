using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class UtilisateursPreferences
    {
        [Key]
        public int NoUtilisateur { get; set; }
        public int NoPreference { get; set; }
        public string Valeur { get; set; }

        public Preferences NoPreferenceNavigation { get; set; }
        public Utilisateurs NoUtilisateurNavigation { get; set; }
    }
}
