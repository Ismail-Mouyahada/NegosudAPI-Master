
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.ProduitService 
{
    public interface IProduitService
    {
        Task<List<Produit>> RecupererToutProduits();
        Task<Produit?> RecupererProduit(int id);
        Task<List<Produit>> AjouterProduit(Produit Produit,IFormFile image);
        Task<List<Produit>?> ModifierProduit(int id, Produit request,IFormFile image);
        Task<List<Produit>?> SupprimerProduit(int id);
        
    }
}