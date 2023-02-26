

 ![logo-negosud](https://user-images.githubusercontent.com/66369128/220627476-59a06d7c-398f-4a77-80b8-3e9ad7555c9a.png)

Documentation complete : https://github.com/Ismail-Mouyahada/NegosudAPI-Master/wiki
# Negosud REST API 
API devloped by Ismail Mouyahada for educational purposes.

link to the API : http://195.154.113.18:8000/swagger/index.html

#Introduction
This API was made to assimilate the needs of Negosud Company. It handels all the HTTP requests made back and forward between the website and WPF client, however let me put in details some technical prerequisits for this REST API.

  # Prequisits 
      - ASP.net core 7
      - DataBase 8.0.01 Mariadb-sever
      - dotnet ef 
    
    + Links
      - Installing ASP.net core 7 : https://learn.microsoft.com/fr-fr/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website
      - Installing Mariadb : https://dev.mysql.com/doc/refman/8.0/en/linux-installation.html
      - Installing dotnet ef : https://learn.microsoft.com/en-us/ef/core/cli/dotnet
   
   
  # Getting started
   
      // to install all the independancies
      dotnet build
      
      // to run the project
      dotnet run 
   
   # Database Configuration (before runing the migrations)
   
     // runing the migrations
    dotnet ef migration add NameOfTheMigration

    //submetting changes to the database
    dotnet ef database update

   # Architecture
   
   
       .
    ├── appsettings.Development.json
    ├── appsettings.json

    # Authentication Controller

    ├── Auth
    │   ├── AuthController.cs
    │   ├── PasswordHash.cs
    │   └── RegisterController.cs

    # Models Controllers 

    ├── Controllers
    │   ├── AdressesController.cs
    │   ├── CataloguesController.cs
    │   ├── CategoriesController.cs
    │   ├── CommandesController.cs
    │   ├── ElemCommandesController.cs
    │   ├── ElemFacturesController.cs
    │   ├── FacturesController.cs
    │   ├── FournisseursController.cs
    │   ├── InventairesController.cs
    │   ├── MagasinsController.cs
    │   ├── PayssController.cs
    │   ├── ProducteursController.cs
    │   ├── ProduitsController.cs
    │   ├── RegionsController.cs
    │   ├── SendMailController.cs
    │   ├── UtilisateursController.cs
    │   └── VillesController.cs

    # Data Context

    ├── Data
    │   └── NegosudDbContext.cs

    # Mail Controller and samples
    ├── Mail
    │   ├── MailSamples
    │   └── SendMail.cs

    # Megrations 

    ├── Migrations
    │   ├── 20230201222111_initialmig.cs
    │   ├── 20230201222111_initialmig.Designer.cs
    │   ├── 20230207213228_start.cs
    │   ├── 20230207213228_start.Designer.cs
    │   └── NegosudDbContextModelSnapshot.cs

    # Models

    ├── Models
    │   ├── Adresse.cs
    │   ├── Catalogue.cs
    │   ├── Categorie.cs
    │   ├── Commande.cs
    │   ├── ConnexionAuth.cs
    │   ├── ElemCommande.cs
    │   ├── ElemFacture.cs
    │   ├── Facture.cs
    │   ├── Fournisseur.cs
    │   ├── Inventaire.cs
    │   ├── Magasin.cs
    │   ├── Mailer.cs
    │   ├── Pays.cs
    │   ├── Producteur.cs
    │   ├── Produit.cs
    │   ├── Region.cs
    │   ├── UtilisateurAuth.cs
    │   ├── Utilisateur.cs
    │   └── Ville.cs

    # Start up main class
    ├── Program.cs
    ├── Properties
    │   └── launchSettings.json


    # Services

    ├── Services
    │   ├── AdresseService
    │   ├── CatalogueService
    │   ├── CategorieSerice
    │   ├── CommandeService
    │   ├── ElemCommandeService
    │   ├── ElemFactureService
    │   ├── FactureService
    │   ├── FournisseurService
    │   ├── InventaireService
    │   ├── MagasinService
    │   ├── MailerService
    │   ├── PaysService
    │   ├── ProducteurService
    │   ├── ProduitService
    │   ├── RegionService
    │   ├── UtilisateurService
    │   └── VilleService
    
    # Testing
    ├── TEST
    │   └── dist
    
    # Files storages
    
    └── wwwroot
        └── uploads

   
