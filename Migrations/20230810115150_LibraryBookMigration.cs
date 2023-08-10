using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryBook.Migrations
{
    /// <inheritdoc />
    public partial class LibraryBookMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    IdAut = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.IdAut);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    IdTheme = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.IdTheme);
                });

            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    IdLivre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnéePub = table.Column<int>(type: "int", nullable: false),
                    IdAut = table.Column<int>(type: "int", nullable: false),
                    IdTheme = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.IdLivre);
                    table.ForeignKey(
                        name: "FK_Livres_Auteurs_IdAut",
                        column: x => x.IdAut,
                        principalTable: "Auteurs",
                        principalColumn: "IdAut",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livres_Themes_IdTheme",
                        column: x => x.IdTheme,
                        principalTable: "Themes",
                        principalColumn: "IdTheme",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    IdSection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLivre = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.IdSection);
                    table.ForeignKey(
                        name: "FK_Sections_Livres_IdLivre",
                        column: x => x.IdLivre,
                        principalTable: "Livres",
                        principalColumn: "IdLivre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livres_IdAut",
                table: "Livres",
                column: "IdAut");

            migrationBuilder.CreateIndex(
                name: "IX_Livres_IdTheme",
                table: "Livres",
                column: "IdTheme");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_IdLivre",
                table: "Sections",
                column: "IdLivre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
