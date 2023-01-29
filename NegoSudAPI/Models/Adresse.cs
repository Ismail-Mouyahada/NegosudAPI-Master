using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace NegoSudAPI.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public string? Rue { get; set; }
        public string? AdressePrincipal { get; set; }
        public string? AdresseComplet { get; set; }
        public string? Ville { get; set; }
        public string? CodePostal { get; set; }
        public string? Region { get; set; }
        public string? Pays { get; set; }
        public string? typeAdresse { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public int? UtilisateurId { get; set; }
        public Utilisateur?  Utilisateur { get; set; }
    }



}