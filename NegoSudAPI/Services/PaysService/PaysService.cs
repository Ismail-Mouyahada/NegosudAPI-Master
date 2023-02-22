
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.PaysService
{ public class PaysService : IPaysService
    {
        private readonly NegosudDbContext _context;

        public PaysService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pays>> AjouterPays(Pays pays)
        {
             if (_context.pays == null)
            {
                throw new ArgumentNullException(nameof(_context.pays), "tout est vide.");
            }
              _context.pays.Add(pays);
            await _context.SaveChangesAsync();
            return await _context.pays.ToListAsync();
        }
        public async Task<List<Pays>?> SupprimerPays(int id)
        {
            if (_context.pays == null)
            {
                throw new ArgumentNullException(nameof(_context.pays), "tout est vide.");
            }
            var pays = await _context.pays.FindAsync(id);
            if (pays is null)
                return null;

            _context.pays.Remove(pays);
            await _context.SaveChangesAsync();

            return await _context.pays.ToListAsync();
        }

        public   Task<List<Pays>> RecupererToutPayss()
        {
            if (_context.pays == null)
            {
                throw new ArgumentNullException(nameof(_context.pays), "tout est vide.");
            }
            var pays =   _context.pays.ToListAsync();
            return pays;
        }

        public async Task<Pays?> RecupererPays(int id)
        {
            if (_context.pays == null)
            {
                throw new ArgumentNullException(nameof(_context.pays), "tout est vide.");
            }
            var pays = await _context.pays.FindAsync(id);
            if (pays is null)
                return null;

            return pays;
        }

        public async Task<List<Pays>?> ModifierPays(int id, Pays request)
        {
            if (_context.pays == null)
            {
                throw new ArgumentNullException(nameof(_context.pays), "tout est vide.");
            }
            var pays = await _context.pays.FindAsync(id);
            if (pays is null)
                return null;

            pays.NamePays  = request.NamePays ;
            
            

            await _context.SaveChangesAsync();

            return await _context.pays.ToListAsync();
        }

        
    }
}
