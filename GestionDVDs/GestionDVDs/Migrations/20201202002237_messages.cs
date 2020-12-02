using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<string>(nullable: false),
                    ExpediteurID = table.Column<int>(nullable: false),
                    RecipientID = table.Column<int>(nullable: false),
                    DateHeure = table.Column<DateTime>(nullable: false),
                    Sujet = table.Column<string>(nullable: false),
                    Corps = table.Column<string>(maxLength: 200, nullable: false),
                    RecipientId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                column: "RecipientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
