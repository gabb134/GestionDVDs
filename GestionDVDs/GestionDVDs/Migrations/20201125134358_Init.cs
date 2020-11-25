using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDVDs.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acteurs",
                columns: table => new
                {
                    ActeurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false),
                    Sexe = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteurs", x => x.ActeurId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    FormatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.FormatId);
                });

            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    LangueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Langue = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.LangueId);
                });

            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.PreferenceId);
                });

            migrationBuilder.CreateTable(
                name: "Producteurs",
                columns: table => new
                {
                    ProducteurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producteurs", x => x.ProducteurId);
                });

            migrationBuilder.CreateTable(
                name: "Realisateurs",
                columns: table => new
                {
                    RealisateurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realisateurs", x => x.RealisateurId);
                });

            migrationBuilder.CreateTable(
                name: "SousTitres",
                columns: table => new
                {
                    SousTitreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LangueSousTitre = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousTitres", x => x.SousTitreId);
                });

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    SupplementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.SupplementId);
                });

            migrationBuilder.CreateTable(
                name: "TypesUtilisateur",
                columns: table => new
                {
                    TypeUtilisateur = table.Column<string>(maxLength: 1, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesUtilisateur", x => x.TypeUtilisateur);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomUtilisateur = table.Column<string>(maxLength: 15, nullable: false),
                    Courriel = table.Column<string>(maxLength: 50, nullable: false),
                    MotPasse = table.Column<int>(nullable: false),
                    TypeUtilisateur = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurId);
                    table.ForeignKey(
                        name: "FK__Utilisate__TypeU__4336F4B9",
                        column: x => x.TypeUtilisateur,
                        principalTable: "TypesUtilisateur",
                        principalColumn: "TypeUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpruntsFilms",
                columns: table => new
                {
                    ExemplaireId = table.Column<int>(nullable: false),
                    UtilisateurId = table.Column<int>(nullable: false),
                    DateEmprunt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpruntsFilms", x => x.ExemplaireId);
                    table.ForeignKey(
                        name: "FK__EmpruntsF__Utili__49E3F248",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exemplaires",
                columns: table => new
                {
                    ExemplaireId = table.Column<int>(nullable: false),
                    UtilisateurProprietaireId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplaires", x => x.ExemplaireId);
                    table.ForeignKey(
                        name: "FK__Exemplair__Utili__4CC05EF3",
                        column: x => x.UtilisateurProprietaireId,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    AnneeSortie = table.Column<int>(nullable: true),
                    Categorie = table.Column<int>(nullable: true),
                    Format = table.Column<int>(nullable: true),
                    DateMAJ = table.Column<DateTime>(type: "datetime", nullable: false),
                    UtilisateurMAJId = table.Column<int>(nullable: false),
                    Resume = table.Column<string>(maxLength: 500, nullable: true),
                    DureeMinutes = table.Column<int>(nullable: true),
                    FilmOriginal = table.Column<int>(nullable: true),
                    ImagePochette = table.Column<string>(maxLength: 50, nullable: true),
                    NbDisques = table.Column<int>(nullable: true),
                    TitreFrancais = table.Column<string>(maxLength: 50, nullable: false),
                    TitreOriginal = table.Column<string>(maxLength: 50, nullable: true),
                    VersionEtendue = table.Column<bool>(nullable: true),
                    RealisateurId = table.Column<int>(nullable: true),
                    ProducteurId = table.Column<int>(nullable: true),
                    XTra = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK__Films__Categorie__4F9CCB9E",
                        column: x => x.Categorie,
                        principalTable: "Categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__Format__5090EFD7",
                        column: x => x.Format,
                        principalTable: "Formats",
                        principalColumn: "FormatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__Producteu__536D5C82",
                        column: x => x.ProducteurId,
                        principalTable: "Producteurs",
                        principalColumn: "ProducteurId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__Realisate__52793849",
                        column: x => x.RealisateurId,
                        principalTable: "Realisateurs",
                        principalColumn: "RealisateurId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__Utilisate__51851410",
                        column: x => x.UtilisateurMAJId,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UtilisateursPreferences",
                columns: table => new
                {
                    UtilisateurId = table.Column<int>(nullable: false),
                    PreferenceId = table.Column<int>(nullable: false),
                    Valeur = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateursPreferences", x => new { x.UtilisateurId, x.PreferenceId });
                    table.ForeignKey(
                        name: "FK__Utilisate__Prefe__4707859D",
                        column: x => x.PreferenceId,
                        principalTable: "Preferences",
                        principalColumn: "PreferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Utilisate__Utili__46136164",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsActeurs",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    ActeurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsActeurs", x => new { x.FilmId, x.ActeurId });
                    table.ForeignKey(
                        name: "FK__FilmsActe__Acteu__573DED66",
                        column: x => x.ActeurId,
                        principalTable: "Acteurs",
                        principalColumn: "ActeurId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsActe__FilmI__5649C92D",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsLangues",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    LangueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsLangues", x => new { x.FilmId, x.LangueId });
                    table.ForeignKey(
                        name: "FK__FilmsLang__FilmI__5A1A5A11",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsLang__Langu__5B0E7E4A",
                        column: x => x.LangueId,
                        principalTable: "Langues",
                        principalColumn: "LangueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsSousTitres",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    SousTitreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsSousTitres", x => new { x.FilmId, x.SousTitreId });
                    table.ForeignKey(
                        name: "FK__FilmsSous__FilmI__5DEAEAF5",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsSous__SousT__5EDF0F2E",
                        column: x => x.SousTitreId,
                        principalTable: "SousTitres",
                        principalColumn: "SousTitreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsSupplements",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    SupplementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsSupplements", x => new { x.FilmId, x.SupplementId });
                    table.ForeignKey(
                        name: "FK__FilmsSupp__FilmI__61BB7BD9",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsSupp__Suppl__62AFA012",
                        column: x => x.SupplementId,
                        principalTable: "Supplements",
                        principalColumn: "SupplementId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpruntsFilms_UtilisateurId",
                table: "EmpruntsFilms",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplaires_UtilisateurProprietaireId",
                table: "Exemplaires",
                column: "UtilisateurProprietaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Categorie",
                table: "Films",
                column: "Categorie");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Format",
                table: "Films",
                column: "Format");

            migrationBuilder.CreateIndex(
                name: "IX_Films_ProducteurId",
                table: "Films",
                column: "ProducteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_RealisateurId",
                table: "Films",
                column: "RealisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_UtilisateurMAJId",
                table: "Films",
                column: "UtilisateurMAJId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsActeurs_ActeurId",
                table: "FilmsActeurs",
                column: "ActeurId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsLangues_LangueId",
                table: "FilmsLangues",
                column: "LangueId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsSousTitres_SousTitreId",
                table: "FilmsSousTitres",
                column: "SousTitreId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsSupplements_SupplementId",
                table: "FilmsSupplements",
                column: "SupplementId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_TypeUtilisateur",
                table: "Utilisateurs",
                column: "TypeUtilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateursPreferences_PreferenceId",
                table: "UtilisateursPreferences",
                column: "PreferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpruntsFilms");

            migrationBuilder.DropTable(
                name: "Exemplaires");

            migrationBuilder.DropTable(
                name: "FilmsActeurs");

            migrationBuilder.DropTable(
                name: "FilmsLangues");

            migrationBuilder.DropTable(
                name: "FilmsSousTitres");

            migrationBuilder.DropTable(
                name: "FilmsSupplements");

            migrationBuilder.DropTable(
                name: "UtilisateursPreferences");

            migrationBuilder.DropTable(
                name: "Acteurs");

            migrationBuilder.DropTable(
                name: "Langues");

            migrationBuilder.DropTable(
                name: "SousTitres");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Producteurs");

            migrationBuilder.DropTable(
                name: "Realisateurs");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "TypesUtilisateur");
        }
    }
}
