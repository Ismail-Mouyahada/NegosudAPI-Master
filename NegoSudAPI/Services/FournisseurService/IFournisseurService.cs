
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.FournisseurService
{
    public interface IFournisseurService
    {
        Task<List<Fournisseur>> RecupererToutFournisseurs();
        Task<Fournisseur?> RecupererFournisseur(int id);
        Task<List<Fournisseur>> AjouterFournisseur(Fournisseur Fournisseur);
        Task<List<Fournisseur>?> ModifierFournisseur(int id, Fournisseur request);
        Task<List<Fournisseur>?> SupprimerFournisseur(int id);
    }
}