
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.PaysService
{
    public interface IPaysService
    {
        Task<List<Pays>> RecupererToutPayss();
        Task<Pays?> RecupererPays(int id);
        Task<List<Pays>> AjouterPays(Pays Pays);
        Task<List<Pays>?> ModifierPays(int id, Pays request);
        Task<List<Pays>?> SupprimerPays(int id);
    }
}