using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Exemplaires
    {
        [Key]
        public int ExemplaireId { get; set; }
        public string UtilisateurProprietaireId { get; set; }

        public ApplicationUser UtilisateurProprietaire { get; set; }
    }
}
