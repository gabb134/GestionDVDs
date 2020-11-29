using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class login2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__EmpruntsF__Utili__49E3F248",
                table: "EmpruntsFilms");

            migrationBuilder.DropForeignKey(
                name: "FK__Exemplair__Utili__4CC05EF3",
                table: "Exemplaires");

            migrationBuilder.DropForeignKey(
                name: "FK__Films__Utilisate__51851410",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK__Utilisate__Utili__46136164",
                table: "UtilisateursPreferences");

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurId",
                table: "UtilisateursPreferences",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurMAJId",
                table: "Films",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurProprietaireId",
                table: "Exemplaires",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurId",
                table: "EmpruntsFilms",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK__EmpruntsF__Utili__49E3F248",
                table: "EmpruntsFilms",
                column: "UtilisateurId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Exemplair__Utili__4CC05EF3",
                table: "Exemplaires",
                column: "UtilisateurProprietaireId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Films__Utilisate__51851410",
                table: "Films",
                column: "UtilisateurMAJId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Utilisate__Utili__46136164",
                table: "UtilisateursPreferences",
                column: "UtilisateurId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__EmpruntsF__Utili__49E3F248",
                table: "EmpruntsFilms");

            migrationBuilder.DropForeignKey(
                name: "FK__Exemplair__Utili__4CC05EF3",
                table: "Exemplaires");

            migrationBuilder.DropForeignKey(
                name: "FK__Films__Utilisate__51851410",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK__Utilisate__Utili__46136164",
                table: "UtilisateursPreferences");

            migrationBuilder.AlterColumn<int>(
                name: "UtilisateurId",
                table: "UtilisateursPreferences",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UtilisateurMAJId",
                table: "Films",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UtilisateurProprietaireId",
                table: "Exemplaires",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UtilisateurId",
                table: "EmpruntsFilms",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK__EmpruntsF__Utili__49E3F248",
                table: "EmpruntsFilms",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Exemplair__Utili__4CC05EF3",
                table: "Exemplaires",
                column: "UtilisateurProprietaireId",
                principalTable: "Utilisateurs",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Films__Utilisate__51851410",
                table: "Films",
                column: "UtilisateurMAJId",
                principalTable: "Utilisateurs",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Utilisate__Utili__46136164",
                table: "UtilisateursPreferences",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
