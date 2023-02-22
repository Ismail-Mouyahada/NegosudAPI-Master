
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.ElemFactureService
{ public class ElemFactureService : IElemFactureService
    {
        private readonly NegosudDbContext _context;

        public ElemFactureService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<ElemFacture>> AjouterElemFacture(ElemFacture elemfacture)
        {
             if (_context.elemFactures  == null)
            {
                throw new ArgumentNullException(nameof(_context.elemFactures), "tout est vide.");
            }
              _context.elemFactures.Add(elemfacture);
            await _context.SaveChangesAsync();
            return await _context.elemFactures.ToListAsync();
        }
        public async Task<List<ElemFacture>?> SupprimerElemFacture(int id)
        {
            if (_context.elemFactures == null)
            {
                throw new ArgumentNullException(nameof(_context.elemFactures), "tout est vide.");
            }
            var elemfacture = await _context.elemFactures.FindAsync(id);
            if (elemfacture is null)
                return null;

            _context.elemFactures.Remove(elemfacture);
            await _context.SaveChangesAsync();

            return await _context.elemFactures.ToListAsync();
        }

        public   Task<List<ElemFacture>> RecupererToutElemFactures()
        {
            if (_context.elemFactures == null)
            {
                throw new ArgumentNullException(nameof(_context.elemFactures), "tout est vide.");
            }
            var elemFactures =   _context.elemFactures.ToListAsync();
            return elemFactures;
        }

        public async Task<ElemFacture?> RecupererElemFacture(int id)
        {
            if (_context.elemFactures == null)
            {
                throw new ArgumentNullException(nameof(_context.elemFactures), "tout est vide.");
            }
            var elemfacture = await _context.elemFactures.FindAsync(id);
            if (elemfacture is null)
                return null;

            return elemfacture;
        }

        public async Task<List<ElemFacture>?> ModifierElemFacture(int id, ElemFacture request)
        {
            if (_context.elemFactures == null)
            {
                throw new ArgumentNullException(nameof(_context.elemFactures), "tout est vide.");
            }
            var elemfacture = await _context.elemFactures.FindAsync(id);
            if (elemfacture is null)
                return null;

            elemfacture.FactureId = request.FactureId;
            elemfacture.DateModification = DateTime.Now;
            elemfacture.Produits = request.Produits;
            

            await _context.SaveChangesAsync();

            return await _context.elemFactures.ToListAsync();
        }

        
    }
}
