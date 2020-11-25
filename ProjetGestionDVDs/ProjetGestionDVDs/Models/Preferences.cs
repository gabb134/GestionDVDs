using System;
using System.Collections.Generic;

namespace ProjetGestionDVDs.Models
{
    public partial class Preferences
    {
        public Preferences()
        {
            UtilisateursPreferences = new HashSet<UtilisateursPreferences>();
        }

        public int PreferenceId { get; set; }
        public string Description { get; set; }

        public ICollection<UtilisateursPreferences> UtilisateursPreferences { get; set; }
    }
}
