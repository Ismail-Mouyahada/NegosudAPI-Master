using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string? NomUtilisateur { get; set; }
        public string? Nom { get; set;}
        public string? Prenom { get; set; }
        public string? Email { get; set;}
        public string? Tel { get; set; }
        public string? MotDePasse { get; set; }
        public int? Role  { get; set; } = 0;
        public bool? IsBusiness { get; set;}
        public string? SIREN  { get; set; }
        // public string? tokenRefesh { get; set;}
        public DateTime? DateInscription  { get; set; }
        public DateTime? DateModification  { get; set; }

    }
}