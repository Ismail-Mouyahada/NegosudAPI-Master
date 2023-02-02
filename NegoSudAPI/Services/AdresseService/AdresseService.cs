
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.AdresseService
{ public class AdresseService : IAdresseService
    {
        private readonly NegosudDbContext _context;

        public AdresseService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Adresse>> AjouterAdresse(Adresse adresse)
        {
             if (_context.adresses == null)
            {
                throw new ArgumentNullException(nameof(_context.adresses), "tout est vide.");
            }
              _context.adresses.Add(adresse);
            await _context.SaveChangesAsync();
            return await _context.adresses.ToListAsync();
        }
        public async Task<List<Adresse>?> SupprimerAdresse(int id)
        {
            if (_context.adresses == null)
            {
                throw new ArgumentNullException(nameof(_context.adresses), "tout est vide.");
            }
            var adresse = await _context.adresses.FindAsync(id);
            if (adresse is null)
                return null;

            _context.adresses.Remove(adresse);
            await _context.SaveChangesAsync();

            return await _context.adresses.ToListAsync();
        }

        public   Task<List<Adresse>> RecupererToutAdresses()
        {
            if (_context.adresses == null)
            {
                throw new ArgumentNullException(nameof(_context.adresses), "tout est vide.");
            }
            var adresses =   _context.adresses.ToListAsync();
            return adresses;
        }

        public async Task<Adresse?> RecupererAdresse(int id)
        {
            if (_context.adresses == null)
            {
                throw new ArgumentNullException(nameof(_context.adresses), "tout est vide.");
            }
            var adresse = await _context.adresses.FindAsync(id);
            if (adresse is null)
                return null;

            return adresse;
        }

        public async Task<List<Adresse>?> ModifierAdresse(int id, Adresse request)
        {
            if (_context.adresses == null)
            {
                throw new ArgumentNullException(nameof(_context.adresses), "tout est vide.");
            }
            var adresse = await _context.adresses.FindAsync(id);
            if (adresse is null)
                return null;

            adresse  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.adresses.ToListAsync();
        }

        
    }
}
