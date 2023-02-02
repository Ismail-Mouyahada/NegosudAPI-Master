
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.ElemCommandeService
{
    public interface IElemCommandeService
    {
        Task<List<ElemCommande>> RecupererToutElemCommandes();
        Task<ElemCommande?> RecupererElemCommande(int id);
        Task<List<ElemCommande>> AjouterElemCommande(ElemCommande ElemCommande);
        Task<List<ElemCommande>?> ModifierElemCommande(int id, ElemCommande request);
        Task<List<ElemCommande>?> SupprimerElemCommande(int id);
    }
}