using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestionDVDs.Models
{
    public class Messages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int MessageId { get; set; }

        [Required]
        public string ExpediteurId { get; set; }

        [Required(ErrorMessage = "Veuillez choisir un recipient")]
        public string RecipientId { get; set; }
            
        public DateTime TempsExpedition { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Veuillez inserer un titre")]
        [StringLength(maximumLength:20, ErrorMessage = "Veuillez limiter votre sujet a 20 caracteres.")]
        public string Sujet { get; set; }

        [Required(ErrorMessage = "Veuillez inserer un message")]
        [StringLength(maximumLength:200, MinimumLength=1, ErrorMessage = "Veuillez assurer que votre message n'excede pas 200 characteres.")]
        public string Corps { get; set; }


        public ApplicationUser Recipient { get; set; }
    }
}
