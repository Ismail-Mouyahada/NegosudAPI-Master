
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Auth;

namespace NegoSudAPI.Services.UtilisateurService
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly NegosudDbContext _context;

        public UtilisateurService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Utilisateur>> AjouterUtilisateur(Utilisateur utilisateur)
        {
            if (_context.utilisateurs == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            utilisateur.MotDePasse = new PasswordHash().HashedPass(utilisateur.MotDePasse);
            utilisateur.Role = 0;

             _context.utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            
            return await _context.utilisateurs.ToListAsync();
        }
        public async Task<List<Utilisateur>?> SupprimerUtilisateur(int id)
        {
            if (_context.utilisateurs == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var utilisateur = await _context.utilisateurs.FindAsync(id);
            if (utilisateur is null)
                return null;

            _context.utilisateurs.Remove(utilisateur);
            await _context.SaveChangesAsync();

            return await _context.utilisateurs.ToListAsync();
        }
        public Task<List<Utilisateur>> RecupererToutUtilisateurs()
        {
            if (_context.utilisateurs == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var utilisateurs = _context.utilisateurs.ToListAsync();
            return utilisateurs;
        }

        public async Task<Utilisateur?> RecupererUtilisateur(int id)
        {
            if (_context.utilisateurs == null)
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var utilisateur = await _context.utilisateurs.FindAsync(id);
            if (utilisateur is null)
                return null;

            return utilisateur;
        }

        public async Task<List<Utilisateur>?> ModifierUtilisateur(int id, Utilisateur request)
        {
            if (_context.utilisateurs == null) 
            {
                throw new ArgumentNullException(nameof(_context.utilisateurs), "tout est vide.");
            }
            var utilisateur = await _context.utilisateurs.FindAsync(id);
            if (utilisateur is null)
                return null;

            utilisateur.Id =  utilisateur.Id  ;
            utilisateur.NomUtilisateur = request.NomUtilisateur;
            utilisateur.Email = request.Email;
            utilisateur.Prenom = request.Prenom;
            utilisateur.Nom = request.Nom;
            if (utilisateur.MotDePasse == new PasswordHash().HashedPass(request.MotDePasse))
            {
              utilisateur.MotDePasse =  request.MotDePasse;
            }else if(utilisateur.MotDePasse != new PasswordHash().HashedPass(request.MotDePasse) || request.MotDePasse == null ){
                utilisateur.MotDePasse =new PasswordHash().HashedPass(request.MotDePasse);
            }
            utilisateur.IsBusiness = request.IsBusiness;
            utilisateur.SIREN = request.SIREN;
            utilisateur.Role = request.Role;
            utilisateur.Tel = request.Tel;
            utilisateur.DateModification = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.utilisateurs.ToListAsync();
        }


    }
}
