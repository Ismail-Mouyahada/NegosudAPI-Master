using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NegoSudAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "adresses",
                columns: new[] { "Id", "AdresseComplet", "AdressePrincipal", "CodePostal", "DateCreation", "DateModification", "Pays", "Region", "Rue", "UtilisateurId", "Ville", "typeAdresse" },
                values: new object[] { 2, "13 rue des champettle", "rue des champelle", "15312", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6185), "France", "Normandie", null, null, "Rouen", null });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "NameCategorie" },
                values: new object[,]
                {
                    { 1, "Vin rouge" },
                    { 2, "Vin Blanc" }
                });

            migrationBuilder.InsertData(
                table: "fournisseurs",
                columns: new[] { "Id", "Adresse", "DateCreation", "DateModification", "Email", "Fix", "NomFournisseur", "Pays", "Region", "Reputation", "Rue", "Tel", "Ville" },
                values: new object[,]
                {
                    { 1, "13 rue des saloumé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6814), "fournisseur1@negosud.com", "+3324515475", "Fournisseur Vin blanc", "France", "Normandie", "Excellent", "12 rue des chameaux", "+33678407516", "Paris" },
                    { 2, "11 rue des saloumé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6836), "fournisseur2@negosud.com", "+3324515475", "Fournisseur Vin Rouge", "France", "Normandie", "Excellent", "12 rue des chameaux", "+33678407516", "Marsaille" }
                });

            migrationBuilder.InsertData(
                table: "pays",
                columns: new[] { "Id", "NamePays" },
                values: new object[,]
                {
                    { 1, "France" },
                    { 2, "Italie" },
                    { 3, "Portugal" },
                    { 4, "Espagne" }
                });

            migrationBuilder.InsertData(
                table: "utilisateurs",
                columns: new[] { "Id", "DateInscription", "DateModification", "Email", "IsBusiness", "MotDePasse", "Nom", "NomUtilisateur", "Prenom", "Role", "SIREN", "Tel" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5586), "ismail.mouyahada@gmail.com", false, null, "Nos", null, "", 1, "515DE1454D56E46", "+3374075061" },
                    { 2, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5600), "ismail.mouyahada@gmail.com", false, null, "Nos", null, "", 1, "515DE1454D56E46", "+3374075061" }
                });

            migrationBuilder.InsertData(
                table: "adresses",
                columns: new[] { "Id", "AdresseComplet", "AdressePrincipal", "CodePostal", "DateCreation", "DateModification", "Pays", "Region", "Rue", "UtilisateurId", "Ville", "typeAdresse" },
                values: new object[] { 1, "13 rue des champettle", "rue des champelle", "15312", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6129), "France", "Normandie", null, 1, "Rouen", null });

            migrationBuilder.InsertData(
                table: "commandes",
                columns: new[] { "Id", "DateCommande", "DateModification", "Remise", "Statut", "UtilisateurId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7386), 15f, "en cours", 1 },
                    { 2, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7446), 15f, "livré", 2 }
                });

            migrationBuilder.InsertData(
                table: "producteurs",
                columns: new[] { "Id", "Adresse", "DateCreation", "DateModification", "Email", "Fix", "FournisseurId", "Nom", "NomProducteur", "Pays", "Prenom", "RaisonSocial", "Region", "Reputation", "Rue", "Tel", "Ville" },
                values: new object[,]
                {
                    { 1, "13 rue des saloumé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6917), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6925), "fournisseur1@negosud.com", "+3324515475", 1, null, "Fournisseur Vin blanc", "France", null, null, "Normandie", "Excellent", "12 rue des chameaux", "+33678407516", "Paris" },
                    { 2, "11 rue des saloumé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6995), "fournisseur2@negosud.com", "+3324515475", 2, null, "Fournisseur Vin Rouge", "France", null, null, "Normandie", "Excellent", "12 rue des chameaux", "+33678407516", "Marsaille" }
                });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Id", "NameRegion", "PaysId" },
                values: new object[,]
                {
                    { 1, "Normandie", 1 },
                    { 2, "Caen", 2 },
                    { 3, "Lour", 3 },
                    { 4, "Paris", 4 }
                });

            migrationBuilder.InsertData(
                table: "elemCommandes",
                columns: new[] { "Id", "Alerte", "CommandeId", "DateCreation", "DateModification", "QuantiteCommande", "SeuilAlerte", "TotalCommande" },
                values: new object[,]
                {
                    { 1, "seuil est dépassé", 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7540), 5, 3, 64.21f },
                    { 2, "seuil est dépassé", 2, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7549), 5, 3, 66.21f }
                });

            migrationBuilder.InsertData(
                table: "factures",
                columns: new[] { "Id", "CommandeId", "DateCreation", "DateModification", "FactureTotal", "Reference" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7620), 45.3f, "FR656D" },
                    { 2, 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7629), 45.3f, "FR326D" }
                });

            migrationBuilder.InsertData(
                table: "magasins",
                columns: new[] { "Id", "Adresse", "CodePostal", "DateCreation", "DateModification", "Email", "Fix", "NomMagasin", "Pays", "ProducteurId", "Region", "Rue", "Tel" },
                values: new object[,]
                {
                    { 1, "13 rue des saloumé", "65412", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7085), "fournisseur1@negosud.com", "+3324515475", "Fournisseur Vin blanc", "France", 1, "Normandie", "12 rue des chameaux", "+33678407516" },
                    { 2, "11 rue des saloumé", "56515", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7097), "fournisseur2@negosud.com", "+3324515475", "Fournisseur Vin Rouge", "France", 2, "Normandie", "12 rue des chameaux", "+33678407516" }
                });

            migrationBuilder.InsertData(
                table: "produits",
                columns: new[] { "Id", "Alcool", "Aliments", "Ancien", "CategorieId", "Conservation", "Couleur", "DateCreation", "DateModification", "Description", "ElemCommandeId", "ElemFactureId", "Expiration", "FournisseurId", "ImagePrincipal", "InventaireId", "NomProduit", "Prix_carton", "Prix_unitaire", "ProducteurId", "Raisins", "Region", "Remise", "Resumee", "SKU", "TVA", "Volume" },
                values: new object[,]
                {
                    { 1, 15.5f, "très amer et acide", "2015", 1, "consummable jusqu'a 2029", "Rouge Foncé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7256), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7263), "that shit happens when the smart wenter faster minster faster", null, null, "2029", null, "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", null, "Fournisseur Vin blanc", 15.4f, 5.3f, 1, "Frais récolté le jenvier 2022 à saint-loire", "Normandie", 10.5f, "smart here this gantis", "CDC5454", 5.14f, 4.3f },
                    { 2, 15.5f, "très amer et acide", "2015", 1, "consummable jusqu'a 2029", "Rouge Foncé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7293), "that shit happens when the smart wenter faster minster faster", null, null, "2029", null, "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", null, "Fournisseur Vin blanc", 15.4f, 5.3f, 2, "Frais récolté le jenvier 2022 à saint-loire", "Normandie", 10.5f, "smart here this gantis", "CDC5454", 5.14f, 4.3f }
                });

            migrationBuilder.InsertData(
                table: "villes",
                columns: new[] { "Id", "NameVille", "RegionId" },
                values: new object[,]
                {
                    { 1, "Paris", 1 },
                    { 2, "Madrid", 2 },
                    { 3, "Rome", 3 },
                    { 4, "Paris", 4 }
                });

            migrationBuilder.InsertData(
                table: "catalogues",
                columns: new[] { "Id", "Image", "ProduitId", "Reference" },
                values: new object[,]
                {
                    { 1, "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", 1, "DEN12" },
                    { 2, "https://www.vinatis.com/62341-thickbox_default/chateauneuf-du-pape-grand-vin-2018-chateau-de-nalys-e-guigal.png", 2, "EDE54" }
                });

            migrationBuilder.InsertData(
                table: "elemFactures",
                columns: new[] { "Id", "DateCreation", "DateModification", "FactureId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7707), 1 },
                    { 2, new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7715), 2 }
                });

            migrationBuilder.InsertData(
                table: "inventaires",
                columns: new[] { "Id", "Appelation", "Classement", "Couleur", "DateCreation", "DateModification", "MagasinId", "Millesime", "Nom", "Position", "QuantiteStock" },
                values: new object[,]
                {
                    { 1, "Fournisseur Vin blanc", "Première rayon 1C4", "Rouge Foncé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7167), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7174), 1, "2016", "Blanc rouge Chapelle", "2 cave, rayon 3", 66 },
                    { 2, "Fournisseur Vin blanc", "Première rayon 1C4", "Rouge Foncé", new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7180), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7184), 2, "2016", "Blanc rouge Chapelle", "2 cave, rayon 3", 66 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "catalogues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "catalogues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "villes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "villes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "villes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
