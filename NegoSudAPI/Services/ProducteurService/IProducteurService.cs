using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;

namespace NegoSudAPI.Services.ProducteurService
{
    public interface IProducteurService
    {
        Task<List<Producteur>> RecupererToutProducteurs();
        Task<Producteur?> RecupererProducteur(int id);
        Task<List<Producteur>> AjouterProducteur(Producteur Producteur);
        Task<List<Producteur>?> ModifierProducteur(int id, Producteur request);
        Task<List<Producteur>?> SupprimerProducteur(int id);
    }
}