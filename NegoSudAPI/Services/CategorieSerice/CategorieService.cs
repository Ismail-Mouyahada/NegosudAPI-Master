
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.CategorieService
{ public class CategorieService : ICategorieService
    {
        private readonly NegosudDbContext _context;

        public CategorieService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Categorie>> AjouterCategorie(Categorie categorie)
        {
             if (_context.categories == null)
            {
                throw new ArgumentNullException(nameof(_context.categories), "tout est vide.");
            }
              _context.categories.Add(categorie);
            await _context.SaveChangesAsync();
            return await _context.categories.ToListAsync();
        }
        public async Task<List<Categorie>?> SupprimerCategorie(int id)
        {
            if (_context.categories == null)
            {
                throw new ArgumentNullException(nameof(_context.categories), "tout est vide.");
            }
            var categorie = await _context.categories.FindAsync(id);
            if (categorie is null)
                return null;

            _context.categories.Remove(categorie);
            await _context.SaveChangesAsync();

            return await _context.categories.ToListAsync();
        }

        public   Task<List<Categorie>> RecupererToutCategories()
        {
            if (_context.categories == null)
            {
                throw new ArgumentNullException(nameof(_context.categories), "tout est vide.");
            }
            var categories =   _context.categories.ToListAsync();
            return categories;
        }

        public async Task<Categorie?> RecupererCategorie(int id)
        {
            if (_context.categories == null)
            {
                throw new ArgumentNullException(nameof(_context.categories), "tout est vide.");
            }
            var categorie = await _context.categories.FindAsync(id);
            if (categorie is null)
                return null;

            return categorie;
        }

        public async Task<List<Categorie>?> ModifierCategorie(int id, Categorie request)
        {
            if (_context.categories == null)
            {
                throw new ArgumentNullException(nameof(_context.categories), "tout est vide.");
            }
            var categorie = await _context.categories.FindAsync(id);
            if (categorie is null)
                return null;

            categorie  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.categories.ToListAsync();
        }

        
    }
}
