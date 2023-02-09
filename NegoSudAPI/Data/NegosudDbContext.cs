using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Auth;
using NegoSudAPI.Models;

namespace NegoSudAPI.Data
{
    public class NegosudDbContext : DbContext
    {

        public NegosudDbContext(DbContextOptions<NegosudDbContext> options) : base(options) { }

        public DbSet<Utilisateur>? utilisateurs { get; set; }
        public DbSet<Adresse>? adresses { get; set; }
        public DbSet<Categorie>? categories { get; set; }
        public DbSet<Catalogue>? catalogues { get; set; }
        public DbSet<Pays>? pays { get; set; }
        public DbSet<Region>? regions { get; set; }
        public DbSet<Ville>? villes { get; set; }
        public DbSet<Fournisseur>? fournisseurs { get; set; }
        public DbSet<Producteur>? producteurs { get; set; }
        public DbSet<Magasin>? magasins { get; set; }
        public DbSet<Inventaire>? inventaires { get; set; }
        public DbSet<Produit>? produits { get; set; }
        public DbSet<Commande>? commandes { get; set; }
        public DbSet<ElemCommande>? elemCommandes { get; set; }
        public DbSet<Facture>? factures { get; set; }
        public DbSet<ElemFacture>? elemFactures { get; set; }
        public DbSet<Mailer>? mailers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur>().HasData(
                    new Utilisateur { Id = 1, Nom = "Nos", Prenom = "", Email = "ismail.mouyahada@viacesi.fr", IsBusiness = false, Role = 1,MotDePasse= new PasswordHash().HashedPass("cube"), SIREN = "515DE1454D56E46", Tel = "+3374075061", DateInscription = DateTime.Now, DateModification = DateTime.Now },
                    new Utilisateur { Id = 2, Nom = "Nos", Prenom = "", Email = "ismail.mouyahada@viacesi.fr", IsBusiness = false, Role = 1,MotDePasse= new PasswordHash().HashedPass("cube"), SIREN = "DE561D5E156564", Tel = "+3374075061", DateInscription = DateTime.Now, DateModification = DateTime.Now }
                    );
            modelBuilder.Entity<Adresse>()
            .HasData(
                    new Adresse { Id = 1, AdresseComplet = "13 rue des champettle", CodePostal = "15312", AdressePrincipal = "rue des champelle", Pays = "France", Ville = "Rouen", Region = "Normandie", DateCreation = DateTime.Now, DateModification = DateTime.Now, UtilisateurId = 1 },
                    new Adresse { Id = 2, AdresseComplet = "13 rue des champettle", CodePostal = "15312", AdressePrincipal = "rue des champelle", Pays = "France", Ville = "Rouen", Region = "Normandie", DateCreation = DateTime.Now, DateModification = DateTime.Now }
                    );
            modelBuilder.Entity<Categorie>()
            .HasData(
                    new Categorie { Id = 1, NameCategorie = "Vin rouge" },
                    new Categorie { Id = 2, NameCategorie = "Vin Blanc" }
                    );
            modelBuilder.Entity<Catalogue>()
            .HasData(
                    new Catalogue { Id = 1, Image = "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", Reference = "DEN12", ProduitId = 1 },
                    new Catalogue { Id = 2, Image = "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", Reference = "EDE54", ProduitId = 2 }
                    );
            modelBuilder.Entity<Pays>()
            .HasData(
                    new Pays { Id = 1, NamePays = "France" },
                    new Pays { Id = 2, NamePays = "Italie" },
                    new Pays { Id = 3, NamePays = "Portugal" },
                    new Pays { Id = 4, NamePays = "Espagne" }
                    );
            modelBuilder.Entity<Region>()
            .HasData(
                    new Region { Id = 1, NameRegion="Normandie", PaysId =1 },
                    new Region { Id = 2, NameRegion="Caen", PaysId =2   },
                    new Region { Id = 3, NameRegion="Lour", PaysId =3 },
                    new Region { Id = 4, NameRegion="Paris", PaysId =4 }
                    );
            modelBuilder.Entity<Ville>()
            .HasData(
                    new Ville { Id = 1, NameVille="Paris", RegionId =1 },
                    new Ville { Id = 2, NameVille="Madrid", RegionId =2   },
                    new Ville { Id = 3, NameVille="Rome", RegionId =3 },
                    new Ville { Id = 4, NameVille="Paris", RegionId =4 }
                    );
            modelBuilder.Entity<Fournisseur>()
            .HasData(
                    new Fournisseur { Id = 1, NomFournisseur ="Fournisseur Vin blanc", Tel="+33678407516" ,Fix="+3324515475", Adresse="13 rue des saloumé",Email = "fournisseur1@negosud.com",Pays="France",Region="Normandie",Reputation="Excellent",Rue="12 rue des chameaux",Ville="Paris" ,DateCreation = DateTime.Now, DateModification= DateTime.Now },
                    new Fournisseur { Id = 2, NomFournisseur ="Fournisseur Vin Rouge", Tel="+33678407516" ,Fix="+3324515475", Adresse="11 rue des saloumé",Email = "fournisseur2@negosud.com",Pays="France",Region="Normandie",Reputation="Excellent",Rue="12 rue des chameaux",Ville="Marsaille" ,DateCreation = DateTime.Now, DateModification= DateTime.Now }
                    );
            modelBuilder.Entity<Producteur>()
            .HasData(
                    new Producteur { Id = 1, NomProducteur ="Fournisseur Vin blanc", Tel="+33678407516" ,Fix="+3324515475", Adresse="13 rue des saloumé",Email = "fournisseur1@negosud.com",Pays="France",Region="Normandie",Reputation="Excellent",Rue="12 rue des chameaux",Ville="Paris" ,DateCreation = DateTime.Now, DateModification= DateTime.Now , FournisseurId=1},
                    new Producteur { Id = 2, NomProducteur ="Fournisseur Vin Rouge", Tel="+33678407516" ,Fix="+3324515475", Adresse="11 rue des saloumé",Email = "fournisseur2@negosud.com",Pays="France",Region="Normandie",Reputation="Excellent",Rue="12 rue des chameaux",Ville="Marsaille" ,DateCreation = DateTime.Now, DateModification= DateTime.Now,FournisseurId=2 }
                    );

            modelBuilder.Entity<Magasin>()
            .HasData(
                    new Magasin { Id = 1, NomMagasin ="Fournisseur Vin blanc", Tel="+33678407516" ,Fix="+3324515475", Adresse="13 rue des saloumé",Email = "fournisseur1@negosud.com",Pays="France",Region="Normandie",Rue="12 rue des chameaux",DateCreation = DateTime.Now, DateModification= DateTime.Now,CodePostal="65412",ProducteurId=1 },
                    new Magasin { Id = 2, NomMagasin ="Fournisseur Vin Rouge", Tel="+33678407516" ,Fix="+3324515475", Adresse="11 rue des saloumé",Email = "fournisseur2@negosud.com",Pays="France",Region="Normandie",Rue="12 rue des chameaux",DateCreation = DateTime.Now, DateModification= DateTime.Now,CodePostal="56515",ProducteurId=2   }
                    );

            modelBuilder.Entity<Inventaire>()
            .HasData(
                    new Inventaire { Id = 1, Appelation ="Fournisseur Vin blanc",Classement="Première rayon 1C4", Couleur ="Rouge Foncé",Millesime="2016",Nom="Blanc rouge Chapelle",Position="2 cave, rayon 3",QuantiteStock=66,DateCreation = DateTime.Now, DateModification= DateTime.Now ,MagasinId=1 },
                    new Inventaire { Id = 2, Appelation ="Fournisseur Vin blanc",Classement="Première rayon 1C4", Couleur ="Rouge Foncé",Millesime="2016",Nom="Blanc rouge Chapelle",Position="2 cave, rayon 3",QuantiteStock=66 ,DateCreation = DateTime.Now, DateModification= DateTime.Now ,MagasinId=2 }
                    );
            modelBuilder.Entity<Produit>()
            .HasData(
                    new Produit { Id = 1, ImagePrincipal="https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", NomProduit ="Fournisseur Vin blanc",Alcool=15.5F,Aliments="très amer et acide",Ancien="2015",Conservation="consummable jusqu'a 2029",CategorieId=1 , Couleur ="Rouge Foncé",DateCreation = DateTime.Now, DateModification= DateTime.Now ,Description="that shit happens when the smart wenter faster minster faster",Expiration="2029",Prix_carton=15.4F,Prix_unitaire=5.3F ,Raisins="Frais récolté le jenvier 2022 à saint-loire",Region="Normandie",Remise=10.5F,ProducteurId=1,Resumee="smart here this gantis",SKU="CDC5454",TVA=5.14F, Volume=4.3F },
                    new Produit { Id = 2, ImagePrincipal="https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", NomProduit ="Fournisseur Vin blanc",Alcool=15.5F,Aliments="très amer et acide",Ancien="2015",Conservation="consummable jusqu'a 2029",CategorieId=1 , Couleur ="Rouge Foncé",DateCreation = DateTime.Now, DateModification= DateTime.Now ,Description="that shit happens when the smart wenter faster minster faster",Expiration="2029",Prix_carton=15.4F,Prix_unitaire=5.3F ,Raisins="Frais récolté le jenvier 2022 à saint-loire",Region="Normandie",Remise=10.5F,ProducteurId=2,Resumee="smart here this gantis",SKU="CDC5454",TVA=5.14F, Volume=4.3F }
                    );
            modelBuilder.Entity<Commande>()
            .HasData(
                    new Commande { Id = 1,Statut="en cours",UtilisateurId=1, Remise=15, DateCommande =DateTime.Now, DateModification = DateTime.Now },
                    new Commande { Id = 2,Statut="livré",UtilisateurId=2, Remise=15, DateCommande =DateTime.Now, DateModification = DateTime.Now }
                    );
            modelBuilder.Entity<ElemCommande>()
            .HasData(
                    new ElemCommande { Id = 1, CommandeId=1,QuantiteCommande=5,SeuilAlerte=3,TotalCommande=64.21F,Alerte="seuil est dépassé", DateCreation =DateTime.Now, DateModification = DateTime.Now },
                    new ElemCommande { Id = 2, CommandeId=2,QuantiteCommande=5,SeuilAlerte=3,TotalCommande=66.21F,Alerte="seuil est dépassé", DateCreation =DateTime.Now, DateModification = DateTime.Now }
                    );
            modelBuilder.Entity<Facture>()
            .HasData(
                    new Facture { Id = 1, CommandeId=1,Reference="FR656D",FactureTotal=45.3F, DateCreation =DateTime.Now, DateModification = DateTime.Now },
                    new Facture {  Id = 2, CommandeId=1,Reference="FR326D",FactureTotal=45.3F, DateCreation =DateTime.Now, DateModification = DateTime.Now  }
                    );
            modelBuilder.Entity<ElemFacture>()
            .HasData(
                    new ElemFacture { Id = 1,FactureId=1, DateCreation =DateTime.Now, DateModification = DateTime.Now },
                    new ElemFacture { Id = 2, FactureId=2, DateCreation =DateTime.Now, DateModification = DateTime.Now }
                    );
        }



    }
}
