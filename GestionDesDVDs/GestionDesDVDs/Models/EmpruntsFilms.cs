using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GestionDesDVDs.Models
{
    public partial class EmpruntsFilms
    {
        [Key]
        public int NoExemplaire { get; set; }
        public int NoUtilisateur { get; set; }
        public DateTime DateEmprunt { get; set; }

        public Utilisateurs NoUtilisateurNavigation { get; set; }
    }
}
