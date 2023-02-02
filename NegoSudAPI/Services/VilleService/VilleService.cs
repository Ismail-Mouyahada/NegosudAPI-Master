
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.VilleService
{ public class VilleService : IVilleService
    {
        private readonly NegosudDbContext _context;

        public VilleService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ville>> AjouterVille(Ville ville)
        {
             if (_context.villes == null)
            {
                throw new ArgumentNullException(nameof(_context.villes), "tout est vide.");
            }
              _context.villes.Add(ville);
            await _context.SaveChangesAsync();
            return await _context.villes.ToListAsync();
        }
        public async Task<List<Ville>?> SupprimerVille(int id)
        {
            if (_context.villes == null)
            {
                throw new ArgumentNullException(nameof(_context.villes), "tout est vide.");
            }
            var ville = await _context.villes.FindAsync(id);
            if (ville is null)
                return null;

            _context.villes.Remove(ville);
            await _context.SaveChangesAsync();

            return await _context.villes.ToListAsync();
        }

        public   Task<List<Ville>> RecupererToutVilles()
        {
            if (_context.villes == null)
            {
                throw new ArgumentNullException(nameof(_context.villes), "tout est vide.");
            }
            var villes =   _context.villes.ToListAsync();
            return villes;
        }

        public async Task<Ville?> RecupererVille(int id)
        {
            if (_context.villes == null)
            {
                throw new ArgumentNullException(nameof(_context.villes), "tout est vide.");
            }
            var ville = await _context.villes.FindAsync(id);
            if (ville is null)
                return null;

            return ville;
        }

        public async Task<List<Ville>?> ModifierVille(int id, Ville request)
        {
            if (_context.villes == null)
            {
                throw new ArgumentNullException(nameof(_context.villes), "tout est vide.");
            }
            var ville = await _context.villes.FindAsync(id);
            if (ville is null)
                return null;

            ville  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.villes.ToListAsync();
        }

        
    }
}
