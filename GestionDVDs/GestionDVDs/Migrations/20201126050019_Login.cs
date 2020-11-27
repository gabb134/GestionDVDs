using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UtilisateursPreferences_PreferenceId",
                table: "UtilisateursPreferences");

            migrationBuilder.DropIndex(
                name: "IX_FilmsActeurs_ActeurId",
                table: "FilmsActeurs");

            migrationBuilder.AlterColumn<string>(
                name: "MotPasse",
                table: "Utilisateurs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_UtilisateursPreferences_PreferenceId_UtilisateurId",
                table: "UtilisateursPreferences",
                columns: new[] { "PreferenceId", "UtilisateurId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_FilmsActeurs_ActeurId_FilmId",
                table: "FilmsActeurs",
                columns: new[] { "ActeurId", "FilmId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_EmpruntsFilms_ExemplaireId_UtilisateurId",
                table: "EmpruntsFilms",
                columns: new[] { "ExemplaireId", "UtilisateurId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_UtilisateursPreferences_PreferenceId_UtilisateurId",
                table: "UtilisateursPreferences");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_FilmsActeurs_ActeurId_FilmId",
                table: "FilmsActeurs");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_EmpruntsFilms_ExemplaireId_UtilisateurId",
                table: "EmpruntsFilms");

            migrationBuilder.AlterColumn<int>(
                name: "MotPasse",
                table: "Utilisateurs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateursPreferences_PreferenceId",
                table: "UtilisateursPreferences",
                column: "PreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsActeurs_ActeurId",
                table: "FilmsActeurs",
                column: "ActeurId");
        }
    }
}
