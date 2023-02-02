
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.InventaireService
{
    public interface IInventaireService
    {
        Task<List<Inventaire>> RecupererToutInventaires();
        Task<Inventaire?> RecupererInventaire(int id);
        Task<List<Inventaire>> AjouterInventaire(Inventaire Inventaire);
        Task<List<Inventaire>?> ModifierInventaire(int id, Inventaire request);
        Task<List<Inventaire>?> SupprimerInventaire(int id);
    }
}