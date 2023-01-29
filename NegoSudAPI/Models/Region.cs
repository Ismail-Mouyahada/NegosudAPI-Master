using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoSudAPI.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string? NameRegion { get; set; }

        public int? PaysId { get; set; }
        public Pays? Pays {get; set;}
    }
}