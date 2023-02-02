
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.VilleService
{
    public interface IVilleService
    {
        Task<List<Ville>> RecupererToutVilles();
        Task<Ville?> RecupererVille(int id);
        Task<List<Ville>> AjouterVille(Ville Ville);
        Task<List<Ville>?> ModifierVille(int id, Ville request);
        Task<List<Ville>?> SupprimerVille(int id);
    }
}