using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GestionDVDs.Models
{
    public class LoginViewModel
    {
         [Required(ErrorMessage = "Veuillez inscrire le nom d'utilisateur.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Veuillez inscrire le mot de passe.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}

