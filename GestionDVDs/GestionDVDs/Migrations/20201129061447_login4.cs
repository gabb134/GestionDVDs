using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class login4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurMAJId",
                table: "Films",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurProprietaireId",
                table: "Exemplaires",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurMAJId",
                table: "Films",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurProprietaireId",
                table: "Exemplaires",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
