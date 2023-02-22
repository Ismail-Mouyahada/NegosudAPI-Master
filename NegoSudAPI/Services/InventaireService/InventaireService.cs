
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.InventaireService
{ public class InventaireService : IInventaireService
    {
        private readonly NegosudDbContext _context;

        public InventaireService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Inventaire>> AjouterInventaire(Inventaire inventaire)
        {
             if (_context.inventaires == null)
            {
                throw new ArgumentNullException(nameof(_context.inventaires), "tout est vide.");
            }
              _context.inventaires.Add(inventaire);
            await _context.SaveChangesAsync();
            return await _context.inventaires.ToListAsync();
        }
        public async Task<List<Inventaire>?> SupprimerInventaire(int id)
        {
            if (_context.inventaires == null)
            {
                throw new ArgumentNullException(nameof(_context.inventaires), "tout est vide.");
            }
            var inventaire = await _context.inventaires.FindAsync(id);
            if (inventaire is null)
                return null;

            _context.inventaires.Remove(inventaire);
            await _context.SaveChangesAsync();

            return await _context.inventaires.ToListAsync();
        }

        public   Task<List<Inventaire>> RecupererToutInventaires()
        {
            if (_context.inventaires == null)
            {
                throw new ArgumentNullException(nameof(_context.inventaires), "tout est vide.");
            }
            var inventaires =   _context.inventaires.ToListAsync();
            return inventaires;
        }

        public async Task<Inventaire?> RecupererInventaire(int id)
        {
            if (_context.inventaires == null)
            {
                throw new ArgumentNullException(nameof(_context.inventaires), "tout est vide.");
            }
            var inventaire = await _context.inventaires.FindAsync(id);
            if (inventaire is null)
                return null;

            return inventaire;
        }

        public async Task<List<Inventaire>?> ModifierInventaire(int id, Inventaire request)
        {
            if (_context.inventaires == null)
            {
                throw new ArgumentNullException(nameof(_context.inventaires), "tout est vide.");
            }
            var inventaire = await _context.inventaires.FindAsync(id);
            if (inventaire is null)
                return null;

            inventaire.Appelation = request.Appelation;
            inventaire.Classement = request.Classement;
            inventaire.Couleur = request.Couleur;
            inventaire.DateModification = request.DateModification;
            inventaire.QuantiteStock = request.QuantiteStock;
            inventaire.Position = request.Position;
            inventaire.MagasinId = request.MagasinId;
            inventaire.Millesime   = request.Millesime;
            inventaire.Nom = request.Nom;

            await _context.SaveChangesAsync();

            return await _context.inventaires.ToListAsync();
        }

        
    }
}
