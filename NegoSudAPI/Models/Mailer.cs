using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Mailer
    {
        public int Id { get; set; }
        [Required]
        public string? EnvoyePar { get; set; }
        [Required]
        public string? Sujet { get; set; }
        [Required]
        public string? Corps { get; set; }
        [Required]
        public string? receptionneur { get; set; }

        public DateTime? DateInscription { get; set; }
    }
}