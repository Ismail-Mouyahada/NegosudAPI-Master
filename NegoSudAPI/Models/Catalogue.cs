using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Catalogue
    {
        public int Id { get; set;}
        public string? Reference { get; set;}
        public string? Image { get; set;}

        
        // Forgein Keys
        public int? ProduitId { get; set;}
        public Produit? Produit { get; set;}

    }
}