using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace WebApplication1.Migrations
{
    public partial class Initiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Prenom = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Nom = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<short>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voiture",
                columns: table => new
                {
                    IdVoiture = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Marque = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Modele = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PersonnesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voiture", x => x.IdVoiture);
                    table.ForeignKey(
                        name: "FK_Voiture_Personne_PersonnesId",
                        column: x => x.PersonnesId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voiture_PersonnesId",
                table: "Voiture",
                column: "PersonnesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voiture");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
