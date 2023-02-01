
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using NegoSudAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Services.ProduitService
{
    public class ProduitService : IProduitService
    {
        private readonly NegosudDbContext _context;

        public ProduitService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produit>> AddProduit(Produit produit)
        {
            _context.produits.Add(produit);
            await _context.SaveChangesAsync();
            return await _context.produits.ToListAsync();
        }

        public async Task<List<Produit>?> DeleteProduit(int id)
        {
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            _context.produits.Remove(produit);
            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }

        public async Task<List<Produit>> GetAllproduits()
        {
            var produits = await _context.produits.ToListAsync();
            return produits;
        }

        public async Task<Produit?> GetProduit(int id)
        {
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            return produit;
        }

        public async Task<List<Produit>?> UpdateProduit(int id, Produit request)
        {
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            produit = request;

            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }

        Task<List<Produit>> IProduitService.AddProduit(Produit book)
        {
            throw new NotImplementedException();
        }

        Task<List<Produit>?> IProduitService.DeleteProduit(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Produit>> IProduitService.GetAllProduits()
        {
            throw new NotImplementedException();
        }

        Task<Produit?> IProduitService.GetProduit(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Produit>?> IProduitService.UpdateProduit(int id, Produit request)
        {
            throw new NotImplementedException();
        }
    }
}
