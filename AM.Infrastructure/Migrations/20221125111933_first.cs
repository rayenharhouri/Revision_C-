using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    CodePays = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monnaie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.CodePays);
                });

            migrationBuilder.CreateTable(
                name: "Tournoi",
                columns: table => new
                {
                    NoTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coef = table.Column<double>(type: "float", nullable: false),
                    Dotation = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournoi", x => x.NoTour);
                });

            migrationBuilder.CreateTable(
                name: "joueurs",
                columns: table => new
                {
                    JoueurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaysFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_joueurs", x => x.JoueurId);
                    table.ForeignKey(
                        name: "FK_joueurs_Pays_PaysFk",
                        column: x => x.PaysFk,
                        principalTable: "Pays",
                        principalColumn: "CodePays",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jouers",
                columns: table => new
                {
                    JoeurFK = table.Column<int>(type: "int", nullable: false),
                    TournoiFK = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jouers", x => new { x.JoeurFK, x.TournoiFK });
                    table.ForeignKey(
                        name: "FK_Jouers_joueurs_JoeurFK",
                        column: x => x.JoeurFK,
                        principalTable: "joueurs",
                        principalColumn: "JoueurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jouers_Tournoi_TournoiFK",
                        column: x => x.TournoiFK,
                        principalTable: "Tournoi",
                        principalColumn: "NoTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jouers_TournoiFK",
                table: "Jouers",
                column: "TournoiFK");

            migrationBuilder.CreateIndex(
                name: "IX_joueurs_PaysFk",
                table: "joueurs",
                column: "PaysFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jouers");

            migrationBuilder.DropTable(
                name: "joueurs");

            migrationBuilder.DropTable(
                name: "Tournoi");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
