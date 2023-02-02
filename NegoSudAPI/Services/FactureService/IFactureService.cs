
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.FactureService
{
    public interface IFactureService
    {
        Task<List<Facture>> RecupererToutFactures();
        Task<Facture?> RecupererFacture(int id);
        Task<List<Facture>> AjouterFacture(Facture Facture);
        Task<List<Facture>?> ModifierFacture(int id, Facture request);
        Task<List<Facture>?> SupprimerFacture(int id);
    }
}