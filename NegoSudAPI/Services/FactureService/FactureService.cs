
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.FactureService
{ public class FactureService : IFactureService
    {
        private readonly NegosudDbContext _context;

        public FactureService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Facture>> AjouterFacture(Facture facture)
        {
             if (_context.factures == null)
            {
                throw new ArgumentNullException(nameof(_context.factures), "tout est vide.");
            }
              _context.factures.Add(facture);
            await _context.SaveChangesAsync();
            return await _context.factures.ToListAsync();
        }
        public async Task<List<Facture>?> SupprimerFacture(int id)
        {
            if (_context.factures == null)
            {
                throw new ArgumentNullException(nameof(_context.factures), "tout est vide.");
            }
            var facture = await _context.factures.FindAsync(id);
            if (facture is null)
                return null;

            _context.factures.Remove(facture);
            await _context.SaveChangesAsync();

            return await _context.factures.ToListAsync();
        }

        public   Task<List<Facture>> RecupererToutFactures()
        {
            if (_context.factures == null)
            {
                throw new ArgumentNullException(nameof(_context.factures), "tout est vide.");
            }
            var factures =   _context.factures.ToListAsync();
            return factures;
        }

        public async Task<Facture?> RecupererFacture(int id)
        {
            if (_context.factures == null)
            {
                throw new ArgumentNullException(nameof(_context.factures), "tout est vide.");
            }
            var facture = await _context.factures.FindAsync(id);
            if (facture is null)
                return null;

            return facture;
        }

        public async Task<List<Facture>?> ModifierFacture(int id, Facture request)
        {
            if (_context.factures == null)
            {
                throw new ArgumentNullException(nameof(_context.factures), "tout est vide.");
            }
            var facture = await _context.factures.FindAsync(id);
            if (facture is null)
                return null;

            facture.CommandeId = request.CommandeId;
            facture.DateModification = request.DateModification;
            facture.FactureTotal = request.FactureTotal;
            facture.Reference = request.Reference;
            facture.DateModification = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.factures.ToListAsync();
        }

        
    }
}
