using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDVDs.Models
{
    public partial class UtilisateursPreferences
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int UtilisateurId { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int PreferenceId { get; set; }
        public string Valeur { get; set; }

        public Preferences Preference { get; set; }
        public Utilisateurs Utilisateur { get; set; }
    }
}
