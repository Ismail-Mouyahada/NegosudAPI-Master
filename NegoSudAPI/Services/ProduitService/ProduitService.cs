
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.ProduitService
{ public class ProduitService : IProduitService
    {
        private readonly NegosudDbContext _context;

        public ProduitService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produit>> AjouterProduit(Produit produit)
        {
             if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
              _context.produits.Add(produit);
            await _context.SaveChangesAsync();
            return await _context.produits.ToListAsync();
        }
        public async Task<List<Produit>?> SupprimerProduit(int id)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            _context.produits.Remove(produit);
            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }

        public   Task<List<Produit>> RecupererToutProduits()
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produits =   _context.produits.ToListAsync();
            return produits;
        }

        public async Task<Produit?> RecupererProduit(int id)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            return produit;
        }

        public async Task<List<Produit>?> ModifierProduit(int id, Produit request)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            produit  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }

        
    }
}
