using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Models;

namespace NegoSudAPI.Data
{
    public class NegosudDbContext: DbContext
    {
        
        public NegosudDbContext(DbContextOptions<NegosudDbContext> options): base(options) { }
      


        public DbSet<Utilisateur>?  utilisateurs { get; set; }  
        public DbSet<Adresse>?  adresses { get; set; }
        public DbSet<Produit>?  produits { get; set; }
        public DbSet<Categorie>?  categories { get; set; }
        public DbSet<Catalogue>?  catalogues     { get; set; }
        public DbSet<Pays>?  pays { get; set; }
        public DbSet<Ville>?  villes { get; set; }
        public DbSet<Region>?   regions { get; set; }
        public DbSet<Fournisseur>?  fournisseurs { get; set; }
        public DbSet<Producteur>?  producteurs { get; set; }
        public DbSet<Commande>?  commandes { get; set; }
        public DbSet<ElemCommande>?  elemCommandes { get; set; }
        public DbSet<Facture>? factures { get; set; }
        public DbSet<ElemFacture>? elemFactures { get; set; }
        public DbSet<Inventaire>? inventaires { get; set; }
        public DbSet<Magasin>? magasins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Utilisateur>().HasData(new {
                Id = 1, NomUtilisateur = "Ismail",Nom="Mouyahada", Prenom="Ismail" ,Role =1, MotDePasse ="Password", Email="mouyahada@gmail.com",IsBusiness=false, SIREN="FR5664544654"
            } );
        }


    }
}
