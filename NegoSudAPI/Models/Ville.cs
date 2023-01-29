using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;

namespace NegoSudAPI.Models
{
    public class Ville
    {
        public int Id { get; set; }
        public string? NameVille { get; set; }

        public int? RegionId { get; set; }
        public Region? Region { get; set; }

    }
}