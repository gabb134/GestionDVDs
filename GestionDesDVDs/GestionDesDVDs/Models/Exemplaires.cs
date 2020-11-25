using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class Exemplaires
    {
        [Key]
        public int NoExemplaire { get; set; }
        public int NoUtilisateurProprietaire { get; set; }

        public Utilisateurs NoUtilisateurProprietaireNavigation { get; set; }
    }
}
