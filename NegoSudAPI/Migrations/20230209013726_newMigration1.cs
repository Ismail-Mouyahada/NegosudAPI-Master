using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegoSudAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCommande", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCommande", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 2, 9, 2, 37, 25, 832, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9717), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification", "Prix_carton", "Prix_unitaire" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9784), 15.4f, 5.3f });

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification", "Prix_carton", "Prix_unitaire" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(9816), 15.4f, 5.3f });

            migrationBuilder.UpdateData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateInscription", "DateModification", "Email", "MotDePasse" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8227), "ismail.mouyahada@viacesi.fr", "TzxBcqT+MIzryEDaZlFx9TSEmx/KEB6vY11o+0Uzk9s=" });

            migrationBuilder.UpdateData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateInscription", "DateModification", "Email", "MotDePasse", "SIREN" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 2, 9, 2, 37, 25, 831, DateTimeKind.Local).AddTicks(8312), "ismail.mouyahada@viacesi.fr", "TzxBcqT+MIzryEDaZlFx9TSEmx/KEB6vY11o+0Uzk9s=", "DE561D5E156564" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "adresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCommande", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "commandes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCommande", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "elemCommandes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "elemFactures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "factures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "fournisseurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7167), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "inventaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7180), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "magasins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6917), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "producteurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateModification", "Prix_carton", "Prix_unitaire" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7256), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7263), null, null });

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateModification", "Prix_carton", "Prix_unitaire" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(7293), null, null });

            migrationBuilder.UpdateData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateInscription", "DateModification", "Email", "MotDePasse" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5586), "ismail.mouyahada@gmail.com", null });

            migrationBuilder.UpdateData(
                table: "utilisateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateInscription", "DateModification", "Email", "MotDePasse", "SIREN" },
                values: new object[] { new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 2, 9, 2, 25, 7, 57, DateTimeKind.Local).AddTicks(5600), "ismail.mouyahada@gmail.com", null, "515DE1454D56E46" });
        }
    }
}
