
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.CatalogueService
{ public class CatalogueService : ICatalogueService
    {
        private readonly NegosudDbContext _context;

        public CatalogueService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Catalogue>> AjouterCatalogue(Catalogue catalogue)
        {
             if (_context.catalogues == null)
            {
                throw new ArgumentNullException(nameof(_context.catalogues), "tout est vide.");
            }
              _context.catalogues.Add(catalogue);
            await _context.SaveChangesAsync();
            return await _context.catalogues.ToListAsync();
        }
        public async Task<List<Catalogue>?> SupprimerCatalogue(int id)
        {
            if (_context.catalogues == null)
            {
                throw new ArgumentNullException(nameof(_context.catalogues), "tout est vide.");
            }
            var catalogue = await _context.catalogues.FindAsync(id);
            if (catalogue is null)
                return null;

            _context.catalogues.Remove(catalogue);
            await _context.SaveChangesAsync();

            return await _context.catalogues.ToListAsync();
        }

        public   Task<List<Catalogue>> RecupererToutCatalogues()
        {
            if (_context.catalogues == null)
            {
                throw new ArgumentNullException(nameof(_context.catalogues), "tout est vide.");
            }
            var catalogues =   _context.catalogues.ToListAsync();
            return catalogues;
        }

        public async Task<Catalogue?> RecupererCatalogue(int id)
        {
            if (_context.catalogues == null)
            {
                throw new ArgumentNullException(nameof(_context.catalogues), "tout est vide.");
            }
            var catalogue = await _context.catalogues.FindAsync(id);
            if (catalogue is null)
                return null;

            return catalogue;
        }

        public async Task<List<Catalogue>?> ModifierCatalogue(int id, Catalogue request)
        {
            if (_context.catalogues == null)
            {
                throw new ArgumentNullException(nameof(_context.catalogues), "tout est vide.");
            }
            var catalogue = await _context.catalogues.FindAsync(id);
            if (catalogue is null)
                return null;

            catalogue  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.catalogues.ToListAsync();
        }

        
    }
}
