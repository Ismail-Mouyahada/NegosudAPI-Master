
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace NegoSudAPI.Services.ProducteurService
{
    public class ProducteurService : IProducteurService
    {
        private readonly NegosudDbContext _context;

        public ProducteurService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producteur>> AjouterProducteur(Producteur producteur)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            _context.producteurs.Add(producteur);
            await _context.SaveChangesAsync();
            return await _context.producteurs.ToListAsync();
        }
        public async Task<List<Producteur>?> SupprimerProducteur(int id)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            _context.producteurs.Remove(producteur);
            await _context.SaveChangesAsync();

            return await _context.producteurs.ToListAsync();
        }

        public Task<List<Producteur>> RecupererToutProducteurs()
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteurs = _context.producteurs.ToListAsync();
            return producteurs;
        }

        public async Task<Producteur?> RecupererProducteur(int id)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            return producteur;
        }

        public async Task<List<Producteur>?> ModifierProducteur(int id, Producteur request)
        {
            if (_context.producteurs == null)
            {
                throw new ArgumentNullException(nameof(_context.producteurs), "tout est vide.");
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur is null)
                return null;

            producteur.NomProducteur = request.NomProducteur;
            producteur.RaisonSocial = request.RaisonSocial;
            producteur.Nom = request.Nom;
            producteur.Prenom = request.Prenom;
            producteur.Tel = request.Tel;
            producteur.Fix = request.Fix;
            producteur.Email = request.Email;
            producteur.Rue = request.Rue;
            producteur.Adresse = request.Adresse;
            producteur.Ville = request.Ville;
            producteur.Region = request.Region;
            producteur.Pays = request.Pays;
            producteur.Reputation = request.Reputation;
            producteur.DateCreation = DateTime.Now;
            producteur.DateModification = DateTime.Now;
            producteur.FournisseurId = request.FournisseurId;
            producteur.Fournisseur = request.Fournisseur;

 
            await _context.SaveChangesAsync();

            return await _context.producteurs.ToListAsync();
        }


    }
}
