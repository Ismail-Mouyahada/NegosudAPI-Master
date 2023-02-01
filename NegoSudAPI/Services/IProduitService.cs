using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NegoSudAPI.Models;
 

namespace NegoSudAPI.Services
{
    public interface IProduitService
    {
        Task<List<Produit>> GetAllProduits();
        Task<Produit?> GetProduit(int id);
        Task<List<Produit>> AddProduit(Produit book);
        Task<List<Produit>?> UpdateProduit(int id, Produit request);
        Task<List<Produit>?> DeleteProduit(int id);
    }
}