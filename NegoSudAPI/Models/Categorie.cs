using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string? NameCategorie { get; set;}

        public ICollection<Produit>? Produit { get; set;}
    }
}