using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;

namespace NegoSudAPI.Models    
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string? NomFournisseur { get; set; }
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

        public ICollection<Produit>? Produits { get; set; }
    }
}