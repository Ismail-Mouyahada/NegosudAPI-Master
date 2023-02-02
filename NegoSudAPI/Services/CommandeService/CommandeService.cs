
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.CommandeService
{ public class CommandeService : ICommandeService
    {
        private readonly NegosudDbContext _context;

        public CommandeService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Commande>> AjouterCommande(Commande commande)
        {
             if (_context.commandes == null)
            {
                throw new ArgumentNullException(nameof(_context.commandes), "tout est vide.");
            }
              _context.commandes.Add(commande);
            await _context.SaveChangesAsync();
            return await _context.commandes.ToListAsync();
        }
        public async Task<List<Commande>?> SupprimerCommande(int id)
        {
            if (_context.commandes == null)
            {
                throw new ArgumentNullException(nameof(_context.commandes), "tout est vide.");
            }
            var commande = await _context.commandes.FindAsync(id);
            if (commande is null)
                return null;

            _context.commandes.Remove(commande);
            await _context.SaveChangesAsync();

            return await _context.commandes.ToListAsync();
        }

        public   Task<List<Commande>> RecupererToutCommandes()
        {
            if (_context.commandes == null)
            {
                throw new ArgumentNullException(nameof(_context.commandes), "tout est vide.");
            }
            var commandes =   _context.commandes.ToListAsync();
            return commandes;
        }

        public async Task<Commande?> RecupererCommande(int id)
        {
            if (_context.commandes == null)
            {
                throw new ArgumentNullException(nameof(_context.commandes), "tout est vide.");
            }
            var commande = await _context.commandes.FindAsync(id);
            if (commande is null)
                return null;

            return commande;
        }

        public async Task<List<Commande>?> ModifierCommande(int id, Commande request)
        {
            if (_context.commandes == null)
            {
                throw new ArgumentNullException(nameof(_context.commandes), "tout est vide.");
            }
            var commande = await _context.commandes.FindAsync(id);
            if (commande is null)
                return null;

            commande  = request ;
            

            await _context.SaveChangesAsync();

            return await _context.commandes.ToListAsync();
        }

        
    }
}
