using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Mailer
    {
        public int Id { get; set; }
        public string? EnvoyePar { get; set; }
        public string? Sujet { get; set; }
        public string? Corps { get; set; }

        public DateTime? DateInscription { get; set; }
    }
}