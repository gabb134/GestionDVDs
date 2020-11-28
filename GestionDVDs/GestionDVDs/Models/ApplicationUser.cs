using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDVDs.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<EmpruntsFilms> EmpruntsFilms { get; set; }
        public ICollection<Exemplaires> Exemplaires { get; set; }
        public ICollection<Films> Films { get; set; }
        public ICollection<UtilisateursPreferences> UtilisateursPreferences { get; set; }
    }
}
