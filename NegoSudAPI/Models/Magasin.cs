using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Magasin
    {
        public int Id { get; set; }
        public string? NomMagasin { get; set;}
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Fix { get; set; }
        public string? Adresse { get; set; }
        public string? Rue { get; set; }
        public string? CodePostal { get; set; }
        public string? Region { get; set; }
        public string? Pays { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public int? ProducteurId { get; set; }
        public Producteur? Producteur {get; set;}

    }
}