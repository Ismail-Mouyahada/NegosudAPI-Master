
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.AdresseService
{
    public interface IAdresseService
    {
        Task<List<Adresse>> RecupererToutAdresses();
        Task<Adresse?> RecupererAdresse(int id);
        Task<List<Adresse>> AjouterAdresse(Adresse Adresse);
        Task<List<Adresse>?> ModifierAdresse(int id, Adresse request);
        Task<List<Adresse>?> SupprimerAdresse(int id);
    }
}