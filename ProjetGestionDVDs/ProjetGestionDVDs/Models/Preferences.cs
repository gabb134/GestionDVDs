using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionDVDs.Models
{
    public partial class Preferences
    {
        public Preferences()
        {
            UtilisateursPreferences = new HashSet<UtilisateursPreferences>();
        }
        [Key]
        public int PreferenceId { get; set; }
        public string Description { get; set; }

        public ICollection<UtilisateursPreferences> UtilisateursPreferences { get; set; }
    }
}
