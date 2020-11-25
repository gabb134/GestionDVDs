using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDesDVDs.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acteurs",
                columns: table => new
                {
                    NoActeur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false),
                    Sexe = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteurs", x => x.NoActeur);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    NoCategorie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.NoCategorie);
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    NoFormat = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.NoFormat);
                });

            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    NoLangue = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Langue = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.NoLangue);
                });

            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    NoPreference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.NoPreference);
                });

            migrationBuilder.CreateTable(
                name: "Producteurs",
                columns: table => new
                {
                    NoProducteur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producteurs", x => x.NoProducteur);
                });

            migrationBuilder.CreateTable(
                name: "Realisateurs",
                columns: table => new
                {
                    NoRealisateur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realisateurs", x => x.NoRealisateur);
                });

            migrationBuilder.CreateTable(
                name: "SousTitres",
                columns: table => new
                {
                    NoSousTitre = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LangueSousTitre = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousTitres", x => x.NoSousTitre);
                });

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    NoSupplement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.NoSupplement);
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
                    NoUtilisateur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomUtilisateur = table.Column<string>(maxLength: 15, nullable: false),
                    Courriel = table.Column<string>(maxLength: 50, nullable: false),
                    MotPasse = table.Column<int>(nullable: false),
                    TypeUtilisateur = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.NoUtilisateur);
                    table.ForeignKey(
                        name: "FK__Utilisate__TypeU__08162EEB",
                        column: x => x.TypeUtilisateur,
                        principalTable: "TypesUtilisateur",
                        principalColumn: "TypeUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpruntsFilms",
                columns: table => new
                {
                    NoExemplaire = table.Column<int>(nullable: false),
                    NoUtilisateur = table.Column<int>(nullable: false),
                    DateEmprunt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpruntsFilms", x => x.NoExemplaire);
                    table.ForeignKey(
                        name: "FK__EmpruntsF__NoUti__0EC32C7A",
                        column: x => x.NoUtilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "NoUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exemplaires",
                columns: table => new
                {
                    NoExemplaire = table.Column<int>(nullable: false),
                    NoUtilisateurProprietaire = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplaires", x => x.NoExemplaire);
                    table.ForeignKey(
                        name: "FK__Exemplair__NoUti__119F9925",
                        column: x => x.NoUtilisateurProprietaire,
                        principalTable: "Utilisateurs",
                        principalColumn: "NoUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    NoFilm = table.Column<int>(nullable: false),
                    AnneeSortie = table.Column<int>(nullable: true),
                    Categorie = table.Column<int>(nullable: true),
                    Format = table.Column<int>(nullable: true),
                    DateMAJ = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoUtilisateurMAJ = table.Column<int>(nullable: false),
                    Resume = table.Column<string>(maxLength: 500, nullable: true),
                    DureeMinutes = table.Column<int>(nullable: true),
                    FilmOriginal = table.Column<int>(nullable: true),
                    ImagePochette = table.Column<string>(maxLength: 50, nullable: true),
                    NbDisques = table.Column<int>(nullable: true),
                    TitreFrancais = table.Column<string>(maxLength: 50, nullable: false),
                    TitreOriginal = table.Column<string>(maxLength: 50, nullable: true),
                    VersionEtendue = table.Column<bool>(nullable: true),
                    NoRealisateur = table.Column<int>(nullable: true),
                    NoProducteur = table.Column<int>(nullable: true),
                    XTra = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.NoFilm);
                    table.ForeignKey(
                        name: "FK__Films__Categorie__147C05D0",
                        column: x => x.Categorie,
                        principalTable: "Categories",
                        principalColumn: "NoCategorie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__Format__15702A09",
                        column: x => x.Format,
                        principalTable: "Formats",
                        principalColumn: "NoFormat",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__NoProduct__184C96B4",
                        column: x => x.NoProducteur,
                        principalTable: "Producteurs",
                        principalColumn: "NoProducteur",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__NoRealisa__1758727B",
                        column: x => x.NoRealisateur,
                        principalTable: "Realisateurs",
                        principalColumn: "NoRealisateur",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Films__NoUtilisa__16644E42",
                        column: x => x.NoUtilisateurMAJ,
                        principalTable: "Utilisateurs",
                        principalColumn: "NoUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UtilisateursPreferences",
                columns: table => new
                {
                    NoUtilisateur = table.Column<int>(nullable: false),
                    NoPreference = table.Column<int>(nullable: false),
                    Valeur = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateursPreferences", x => new { x.NoUtilisateur, x.NoPreference });
                    table.UniqueConstraint("AK_UtilisateursPreferences_NoUtilisateur", x => x.NoUtilisateur);
                    table.ForeignKey(
                        name: "FK__Utilisate__NoPre__0BE6BFCF",
                        column: x => x.NoPreference,
                        principalTable: "Preferences",
                        principalColumn: "NoPreference",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Utilisate__NoUti__0AF29B96",
                        column: x => x.NoUtilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "NoUtilisateur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsActeurs",
                columns: table => new
                {
                    NoFilm = table.Column<int>(nullable: false),
                    NoActeur = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsActeurs", x => new { x.NoFilm, x.NoActeur });
                    table.UniqueConstraint("AK_FilmsActeurs_NoFilm", x => x.NoFilm);
                    table.ForeignKey(
                        name: "FK__FilmsActe__NoAct__1C1D2798",
                        column: x => x.NoActeur,
                        principalTable: "Acteurs",
                        principalColumn: "NoActeur",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsActe__NoFil__1B29035F",
                        column: x => x.NoFilm,
                        principalTable: "Films",
                        principalColumn: "NoFilm",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsLangues",
                columns: table => new
                {
                    NoFilm = table.Column<int>(nullable: false),
                    NoLangue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsLangues", x => new { x.NoFilm, x.NoLangue });
                    table.UniqueConstraint("AK_FilmsLangues_NoFilm", x => x.NoFilm);
                    table.ForeignKey(
                        name: "FK__FilmsLang__NoFil__1EF99443",
                        column: x => x.NoFilm,
                        principalTable: "Films",
                        principalColumn: "NoFilm",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsLang__NoLan__1FEDB87C",
                        column: x => x.NoLangue,
                        principalTable: "Langues",
                        principalColumn: "NoLangue",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsSousTitres",
                columns: table => new
                {
                    NoFilm = table.Column<int>(nullable: false),
                    NoSousTitre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsSousTitres", x => new { x.NoFilm, x.NoSousTitre });
                    table.UniqueConstraint("AK_FilmsSousTitres_NoFilm", x => x.NoFilm);
                    table.ForeignKey(
                        name: "FK__FilmsSous__NoFil__22CA2527",
                        column: x => x.NoFilm,
                        principalTable: "Films",
                        principalColumn: "NoFilm",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsSous__NoSou__23BE4960",
                        column: x => x.NoSousTitre,
                        principalTable: "SousTitres",
                        principalColumn: "NoSousTitre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmsSupplements",
                columns: table => new
                {
                    NoFilm = table.Column<int>(nullable: false),
                    NoSupplement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsSupplements", x => new { x.NoFilm, x.NoSupplement });
                    table.UniqueConstraint("AK_FilmsSupplements_NoFilm", x => x.NoFilm);
                    table.ForeignKey(
                        name: "FK__FilmsSupp__NoFil__269AB60B",
                        column: x => x.NoFilm,
                        principalTable: "Films",
                        principalColumn: "NoFilm",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FilmsSupp__NoSup__278EDA44",
                        column: x => x.NoSupplement,
                        principalTable: "Supplements",
                        principalColumn: "NoSupplement",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpruntsFilms_NoUtilisateur",
                table: "EmpruntsFilms",
                column: "NoUtilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplaires_NoUtilisateurProprietaire",
                table: "Exemplaires",
                column: "NoUtilisateurProprietaire");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Categorie",
                table: "Films",
                column: "Categorie");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Format",
                table: "Films",
                column: "Format");

            migrationBuilder.CreateIndex(
                name: "IX_Films_NoProducteur",
                table: "Films",
                column: "NoProducteur");

            migrationBuilder.CreateIndex(
                name: "IX_Films_NoRealisateur",
                table: "Films",
                column: "NoRealisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Films_NoUtilisateurMAJ",
                table: "Films",
                column: "NoUtilisateurMAJ");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsActeurs_NoActeur",
                table: "FilmsActeurs",
                column: "NoActeur");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsLangues_NoLangue",
                table: "FilmsLangues",
                column: "NoLangue");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsSousTitres_NoSousTitre",
                table: "FilmsSousTitres",
                column: "NoSousTitre");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsSupplements_NoSupplement",
                table: "FilmsSupplements",
                column: "NoSupplement");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_TypeUtilisateur",
                table: "Utilisateurs",
                column: "TypeUtilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateursPreferences_NoPreference",
                table: "UtilisateursPreferences",
                column: "NoPreference");
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
