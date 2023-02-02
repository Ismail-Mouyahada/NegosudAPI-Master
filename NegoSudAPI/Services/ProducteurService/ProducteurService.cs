
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.ProducteurService
{ public class ProducteurService : IProducteurService
    {
        private readonly NegosudDbContext _context;

        public ProducteurService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producteur>> AjouterProducteur(Producteur producteur)
        {
             if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
              _context.producteurs.Add(producteur);
            await _context.SaveChangesAsync();
            return await _context.producteurs.ToListAsync();
        }
        public async Task<List<Producteur>?> SupprimerProducteur(int id)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            _context.producteurs.Remove(producteur);
            await _context.SaveChangesAsync();

            return await _context.producteurs.ToListAsync();
        }

        public   Task<List<Producteur>> RecupererToutProducteurs()
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteurs =   _context.producteurs.ToListAsync();
            return producteurs;
        }

        public async Task<Producteur?> RecupererProducteur(int id)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            return producteur;
        }

        public async Task<List<Producteur>?> ModifierProducteur(int id, Producteur request)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            producteur  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.producteurs.ToListAsync();
        }

        
    }
}
