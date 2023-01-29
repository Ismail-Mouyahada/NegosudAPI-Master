using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;

namespace NegoSudAPI.Models
{
    public class Inventaire
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Appelation { get; set; }
        public  string? Couleur { get; set; }
        public  string? Classement { get; set; }
        public string? Millesime { get; set; }
        public string? Position { get; set;}
        public int QuantiteStock { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public int? MagasinId { get; set; }
        public Magasin? Magasin {get; set;}

        public IList<Produit>? Produits { get; set; }

    }
}