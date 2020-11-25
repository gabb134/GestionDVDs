using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Exemplaires
    {
        [Key]
        public int ExemplaireId { get; set; }
        public int UtilisateurProprietaireId { get; set; }

        public Utilisateurs UtilisateurProprietaire { get; set; }
    }
}
