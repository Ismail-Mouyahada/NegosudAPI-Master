using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class ElemFacture
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public int? FactureId { get; set; }
        public Facture? Facture { get; set; }

        public ICollection<Produit>? Produits { get; set; }

    }
}