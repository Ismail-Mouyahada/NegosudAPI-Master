
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace NegoSudAPI.Services.ProduitService
{
    public class ProduitService : IProduitService
    {
        private readonly NegosudDbContext _context;

        public ProduitService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produit>> AjouterProduit(Produit produit, IFormFile image)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }

            if (image != null && image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await image.CopyToAsync(ms);
                    produit.ImagePrincipal = ms.ToString();
                }
            }



            _context.produits.Add(produit);
            await _context.SaveChangesAsync();
            return await _context.produits.ToListAsync();
        }
        public async Task<List<Produit>?> SupprimerProduit(int id)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            _context.produits.Remove(produit);
            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }

        public Task<List<Produit>> RecupererToutProduits()
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produits = _context.produits.ToListAsync();
            return produits;
        }

        public async Task<Produit?> RecupererProduit(int id)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            return produit;
        }

        public async Task<List<Produit>?> ModifierProduit(int id, Produit request, IFormFile image)
        {
            if (_context.produits == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var produit = await _context.produits.FindAsync(id);
            if (produit is null)
                return null;

            produit.SKU = request.SKU;
            produit.NomProduit = request.NomProduit;
            produit.Alcool = request.Alcool;
            produit.Description = request.Description;
            produit.Aliments = request.Aliments;
            produit.Prix_carton = request.Prix_carton;
            produit.Prix_unitaire = request.Prix_unitaire;
            produit.Conservation = request.Conservation;
            produit.Couleur = request.Couleur;
            produit.Raisins = request.Raisins;
            produit.Remise = request.Remise;
            produit.Resumee = request.Resumee;
            produit.Volume = request.Volume;
            produit.Region = request.Region;
            produit.TVA = request.TVA;
            produit.Expiration = request.Expiration;
            produit.CategorieId = request.CategorieId;
            produit.ProducteurId = request.ProducteurId;
            produit.DateModification = DateTime.Now;
            produit.DateCreation = DateTime.Now;

            if (image != null && image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await image.CopyToAsync(ms);
                    produit.ImagePrincipal = ms.ToString();
                }
            }



            await _context.SaveChangesAsync();

            return await _context.produits.ToListAsync();
        }


    }
}
