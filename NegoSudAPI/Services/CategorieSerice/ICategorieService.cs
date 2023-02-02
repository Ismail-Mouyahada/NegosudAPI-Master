
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.CategorieService
{
    public interface ICategorieService
    {
        Task<List<Categorie>> RecupererToutCategories();
        Task<Categorie?> RecupererCategorie(int id);
        Task<List<Categorie>> AjouterCategorie(Categorie Categorie);
        Task<List<Categorie>?> ModifierCategorie(int id, Categorie request);
        Task<List<Categorie>?> SupprimerCategorie(int id);
    }
}