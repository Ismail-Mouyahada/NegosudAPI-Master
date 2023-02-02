
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.MagasinService
{
    public interface IMagasinService
    {
        Task<List<Magasin>> RecupererToutMagasins();
        Task<Magasin?> RecupererMagasin(int id);
        Task<List<Magasin>> AjouterMagasin(Magasin Magasin);
        Task<List<Magasin>?> ModifierMagasin(int id, Magasin request);
        Task<List<Magasin>?> SupprimerMagasin(int id);
    }
}