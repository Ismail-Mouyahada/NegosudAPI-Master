
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.UtilisateurService
{
    public interface IUtilisateurService
    {
        Task<List<Utilisateur>> RecupererToutUtilisateurs();
        Task<Utilisateur?> RecupererUtilisateur(int id);
        Task<List<Utilisateur>> AjouterUtilisateur(Utilisateur Utilisateur);
        Task<List<Utilisateur>?> ModifierUtilisateur(int id, Utilisateur request);
        Task<List<Utilisateur>?> SupprimerUtilisateur(int id);
    }
}