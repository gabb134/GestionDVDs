using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDVDs.Models
{
    public partial class EmpruntsFilms
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int ExemplaireId { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int UtilisateurId { get; set; }
        public DateTime DateEmprunt { get; set; }

        public Utilisateurs Utilisateur { get; set; }
    }
}
