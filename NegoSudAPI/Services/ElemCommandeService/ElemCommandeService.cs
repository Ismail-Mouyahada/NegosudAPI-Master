
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.ElemCommandeService
{ public class ElemCommandeService : IElemCommandeService
    {
        private readonly NegosudDbContext _context;

        public ElemCommandeService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<ElemCommande>> AjouterElemCommande(ElemCommande elemcommande)
        {
             if (_context.elemCommandes == null)
            {
                throw new ArgumentNullException(nameof(_context.elemCommandes), "tout est vide.");
            }
              _context.elemCommandes.Add(elemcommande);
            await _context.SaveChangesAsync();
            return await _context.elemCommandes.ToListAsync();
        }
        public async Task<List<ElemCommande>?> SupprimerElemCommande(int id)
        {
            if (_context.elemCommandes == null)
            {
                throw new ArgumentNullException(nameof(_context.elemCommandes), "tout est vide.");
            }
            var elemcommande = await _context.elemCommandes.FindAsync(id);
            if (elemcommande is null)
                return null;

            _context.elemCommandes.Remove(elemcommande);
            await _context.SaveChangesAsync();

            return await _context.elemCommandes.ToListAsync();
        }

        public   Task<List<ElemCommande>> RecupererToutElemCommandes()
        {
            if (_context.elemCommandes == null)
            {
                throw new ArgumentNullException(nameof(_context.elemCommandes), "tout est vide.");
            }
            var elemCommandes =   _context.elemCommandes.ToListAsync();
            return elemCommandes;
        }

        public async Task<ElemCommande?> RecupererElemCommande(int id)
        {
            if (_context.elemCommandes == null)
            {
                throw new ArgumentNullException(nameof(_context.elemCommandes), "tout est vide.");
            }
            var elemcommande = await _context.elemCommandes.FindAsync(id);
            if (elemcommande is null)
                return null;

            return elemcommande;
        }

        public async Task<List<ElemCommande>?> ModifierElemCommande(int id, ElemCommande request)
        {
            if (_context.elemCommandes == null)
            {
                throw new ArgumentNullException(nameof(_context.elemCommandes), "tout est vide.");
            }
            var elemcommande = await _context.elemCommandes.FindAsync(id);
            if (elemcommande is null)
                return null;

            elemcommande  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.elemCommandes.ToListAsync();
        }

        
    }
}
