
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.ProduitService 
{
    public interface IProduitService
    {
        Task<List<Produit>> RecupererToutProduits();
        Task<Produit?> RecupererProduit(int id);
        Task<List<Produit>> AjouterProduit(Produit Produit);
        Task<List<Produit>?> ModifierProduit(int id, Produit request);
        Task<List<Produit>?> SupprimerProduit(int id);
        
    }
}