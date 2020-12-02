using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class MessagesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_RecipientId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RecipientID",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ExpediteurID",
                table: "Messages",
                newName: "ExpediteurId");

            migrationBuilder.RenameColumn(
                name: "DateHeure",
                table: "Messages",
                newName: "TempsExpedition");

            migrationBuilder.AlterColumn<string>(
                name: "Sujet",
                table: "Messages",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RecipientId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpediteurId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_RecipientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ExpediteurId",
                table: "Messages",
                newName: "ExpediteurID");

            migrationBuilder.RenameColumn(
                name: "TempsExpedition",
                table: "Messages",
                newName: "DateHeure");

            migrationBuilder.AlterColumn<string>(
                name: "Sujet",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RecipientId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ExpediteurID",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "RecipientID",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "AspNetUsers",
                principalColumn: "UtilisateurId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
