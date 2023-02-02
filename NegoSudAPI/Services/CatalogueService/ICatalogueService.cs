
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.CatalogueService
{
    public interface ICatalogueService
    {
        Task<List<Catalogue>> RecupererToutCatalogues();
        Task<Catalogue?> RecupererCatalogue(int id);
        Task<List<Catalogue>> AjouterCatalogue(Catalogue Catalogue);
        Task<List<Catalogue>?> ModifierCatalogue(int id, Catalogue request);
        Task<List<Catalogue>?> SupprimerCatalogue(int id);
    }
}