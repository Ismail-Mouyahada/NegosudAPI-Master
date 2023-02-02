using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class ConnexionAuth
    {

        public string? NomUtilisateur { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? MotDePasse { get; set; }
        public bool? IsBusiness { get; set; }
        public string? SIREN { get; set; }

    }
}