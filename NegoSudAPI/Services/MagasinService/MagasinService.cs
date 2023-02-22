
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.MagasinService
{ public class MagasinService : IMagasinService
    {
        private readonly NegosudDbContext _context;

        public MagasinService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Magasin>> AjouterMagasin(Magasin magasin)
        {
             if (_context.magasins == null)
            {
                throw new ArgumentNullException(nameof(_context.magasins), "tout est vide.");
            }
              _context.magasins.Add(magasin);
            await _context.SaveChangesAsync();
            return await _context.magasins.ToListAsync();
        }
        public async Task<List<Magasin>?> SupprimerMagasin(int id)
        {
            if (_context.magasins == null)
            {
                throw new ArgumentNullException(nameof(_context.magasins), "tout est vide.");
            }
            var magasin = await _context.magasins.FindAsync(id);
            if (magasin is null)
                return null;

            _context.magasins.Remove(magasin);
            await _context.SaveChangesAsync();

            return await _context.magasins.ToListAsync();
        }

        public   Task<List<Magasin>> RecupererToutMagasins()
        {
            if (_context.magasins == null)
            {
                throw new ArgumentNullException(nameof(_context.magasins), "tout est vide.");
            }
            var magasins =   _context.magasins.ToListAsync();
            return magasins;
        }

        public async Task<Magasin?> RecupererMagasin(int id)
        {
            if (_context.magasins == null)
            {
                throw new ArgumentNullException(nameof(_context.magasins), "tout est vide.");
            }
            var magasin = await _context.magasins.FindAsync(id);
            if (magasin is null)
                return null;

            return magasin;
        }

        public async Task<List<Magasin>?> ModifierMagasin(int id, Magasin request)
        {
            if (_context.magasins == null)
            {
                throw new ArgumentNullException(nameof(_context.magasins), "tout est vide.");
            }
            var magasin = await _context.magasins.FindAsync(id);
            if (magasin is null)
                return null;

            magasin.Adresse  = request.Adresse ;
            magasin.CodePostal = request.CodePostal;
            magasin.Email = request.Email;
            magasin.NomMagasin = request.NomMagasin;
            magasin.Tel = request.Tel;
            magasin.Fix = request.Fix;
            magasin.DateModification = request.DateModification;
            magasin.Pays = request.Pays;
            magasin.ProducteurId = request.ProducteurId;
          
        
            

            await _context.SaveChangesAsync();

            return await _context.magasins.ToListAsync();
        }

        
    }
}
