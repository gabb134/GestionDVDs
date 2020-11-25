using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDesDVDs.Migrations
{
    public partial class addID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsSupplements_NoFilm",
                table: "FilmsSupplements");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsSousTitres_NoFilm",
                table: "FilmsSousTitres");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsLangues_NoFilm",
                table: "FilmsLangues");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsActeurs_NoFilm",
                table: "FilmsActeurs");

            migrationBuilder.RenameColumn(
                name: "NoFilm",
                table: "FilmsSupplements",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "NoFilm",
                table: "FilmsSousTitres",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "NoFilm",
                table: "FilmsLangues",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "NoFilm",
                table: "FilmsActeurs",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "NoFilm",
                table: "Films",
                newName: "FilmId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsSupplements_FilmId",
                table: "FilmsSupplements",
                column: "FilmId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsSousTitres_FilmId",
                table: "FilmsSousTitres",
                column: "FilmId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsLangues_FilmId",
                table: "FilmsLangues",
                column: "FilmId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsActeurs_FilmId",
                table: "FilmsActeurs",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsSupplements_FilmId",
                table: "FilmsSupplements");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsSousTitres_FilmId",
                table: "FilmsSousTitres");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsLangues_FilmId",
                table: "FilmsLangues");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsActeurs_FilmId",
                table: "FilmsActeurs");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "FilmsSupplements",
                newName: "NoFilm");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "FilmsSousTitres",
                newName: "NoFilm");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "FilmsLangues",
                newName: "NoFilm");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "FilmsActeurs",
                newName: "NoFilm");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Films",
                newName: "NoFilm");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsSupplements_NoFilm",
                table: "FilmsSupplements",
                column: "NoFilm");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsSousTitres_NoFilm",
                table: "FilmsSousTitres",
                column: "NoFilm");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsLangues_NoFilm",
                table: "FilmsLangues",
                column: "NoFilm");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsActeurs_NoFilm",
                table: "FilmsActeurs",
                column: "NoFilm");
        }
    }
}
