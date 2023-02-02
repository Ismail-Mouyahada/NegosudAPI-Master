
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.ElemFactureService
{
    public interface IElemFactureService
    {
        Task<List<ElemFacture>> RecupererToutElemFactures();
        Task<ElemFacture?> RecupererElemFacture(int id);
        Task<List<ElemFacture>> AjouterElemFacture(ElemFacture ElemFacture);
        Task<List<ElemFacture>?> ModifierElemFacture(int id, ElemFacture request);
        Task<List<ElemFacture>?> SupprimerElemFacture(int id);
    }
}