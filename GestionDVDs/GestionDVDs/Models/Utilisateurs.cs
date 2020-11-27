using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDVDs.Models
{
    public partial class Utilisateurs 
    {

        public Utilisateurs()
        {
            EmpruntsFilms = new HashSet<EmpruntsFilms>();
            Exemplaires = new HashSet<Exemplaires>();
            Films = new HashSet<Films>();
            UtilisateursPreferences = new HashSet<UtilisateursPreferences>();
        }
        [Key]
        public int UtilisateurId { get; set; }
        public string NomUtilisateur { get; set; }
        public string Courriel { get; set; }
        public string MotPasse { get; set; }
        public char TypeUtilisateur { get; set; }

        public TypesUtilisateur TypeUtilisateurNavigation { get; set; }
        public ICollection<EmpruntsFilms> EmpruntsFilms { get; set; }
        public ICollection<Exemplaires> Exemplaires { get; set; }
        public ICollection<Films> Films { get; set; }
        public ICollection<UtilisateursPreferences> UtilisateursPreferences { get; set; }
    }
}
