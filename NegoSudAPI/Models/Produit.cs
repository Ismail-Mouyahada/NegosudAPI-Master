using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Produit
    {

        public int Id { get; set; }
        public string? SKU { get; set; }
        public string? NomProduit { get; set; }
        public string? Resumee { get; set; }
        public string? Description { get; set; }
        public float? Prix_unitaire { get; set; }
        public float? Prix_carton { get; set; }
        public float? TVA { get; set; }
        public float? Remise { get; set; }
        public string? ImagePrincipal { get; set; }
        public string? Ancien { get; set; }
        public string? Region { get; set; }
        public string? Couleur { get; set; }
        public string? Raisins { get; set; }
        public float? Alcool { get; set; }
        public string? Aliments { get; set; }
        public string? Conservation { get; set; }
        public string? Expiration { get; set; }
        public float Volume { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        // Foreign keys
        public int? ProducteurId { get; set; }

        public Producteur? Producteur { get; set; }
        public int? CategorieId { get; set; }
        public Categorie? Categorie { get; set; }



    }
}