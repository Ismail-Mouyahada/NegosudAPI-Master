
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.CommandeService
{
    public interface ICommandeService
    {
        Task<List<Commande>> RecupererToutCommandes();
        Task<Commande?> RecupererCommande(int id);
        Task<List<Commande>> AjouterCommande(Commande Commande);
        Task<List<Commande>?> ModifierCommande(int id, Commande request);
        Task<List<Commande>?> SupprimerCommande(int id);
    }
}