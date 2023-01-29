using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models    
{
    public class Facture
    {
        public int Id { get; set; }
        public string? Reference { get; set; }
        public float FactureTotal { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        // Foreign keys
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
 
    }
}