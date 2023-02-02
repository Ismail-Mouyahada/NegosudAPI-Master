
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.FournisseurService
{ public class FournisseurService : IFournisseurService
    {
        private readonly NegosudDbContext _context;

        public FournisseurService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fournisseur>> AjouterFournisseur(Fournisseur fournisseur)
        {
             if (_context.fournisseurs == null)
            {
                throw new ArgumentNullException(nameof(_context.fournisseurs), "tout est vide.");
            }
              _context.fournisseurs.Add(fournisseur);
            await _context.SaveChangesAsync();
            return await _context.fournisseurs.ToListAsync();
        }
        public async Task<List<Fournisseur>?> SupprimerFournisseur(int id)
        {
            if (_context.fournisseurs == null)
            {
                throw new ArgumentNullException(nameof(_context.fournisseurs), "tout est vide.");
            }
            var fournisseur = await _context.fournisseurs.FindAsync(id);
            if (fournisseur is null)
                return null;

            _context.fournisseurs.Remove(fournisseur);
            await _context.SaveChangesAsync();

            return await _context.fournisseurs.ToListAsync();
        }

        public   Task<List<Fournisseur>> RecupererToutFournisseurs()
        {
            if (_context.fournisseurs == null)
            {
                throw new ArgumentNullException(nameof(_context.fournisseurs), "tout est vide.");
            }
            var fournisseurs =   _context.fournisseurs.ToListAsync();
            return fournisseurs;
        }

        public async Task<Fournisseur?> RecupererFournisseur(int id)
        {
            if (_context.fournisseurs == null)
            {
                throw new ArgumentNullException(nameof(_context.fournisseurs), "tout est vide.");
            }
            var fournisseur = await _context.fournisseurs.FindAsync(id);
            if (fournisseur is null)
                return null;

            return fournisseur;
        }

        public async Task<List<Fournisseur>?> ModifierFournisseur(int id, Fournisseur request)
        {
            if (_context.fournisseurs == null)
            {
                throw new ArgumentNullException(nameof(_context.fournisseurs), "tout est vide.");
            }
            var fournisseur = await _context.fournisseurs.FindAsync(id);
            if (fournisseur is null)
                return null;

            fournisseur  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.fournisseurs.ToListAsync();
        }

        
    }
}
