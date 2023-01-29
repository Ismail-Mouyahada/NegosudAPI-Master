using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;

namespace NegoSudAPI.Models
{
    public class Producteur
    {
        public int Id { get; set; }
        public string? NomProducteur { get; set; }
        public string? RaisonSocial { get; set; }
        public string? Nom {get; set;}
        public string? Prenom {get; set;}
        public string? Tel { get; set; }
        public string? Fix { get; set; }
        public string? Email { get; set; }
        public string? Rue { get; set; }
        public string? Adresse { get; set; }
        public string? Ville { get; set; }
        public string? Region { get; set; }
        public string? Pays { get; set; }
        public string? Reputation { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public int? FournisseurId { get; set; }
        public Fournisseur? Fournisseur {get; set;}
    }
}