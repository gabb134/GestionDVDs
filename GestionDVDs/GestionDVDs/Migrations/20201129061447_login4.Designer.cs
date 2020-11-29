﻿// <auto-generated />
using System;
using GestionDVDs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionDVDs.Migrations
{
    [DbContext(typeof(BDW56_424rContext))]
    [Migration("20201129061447_login4")]
    partial class login4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionDVDs.Models.Acteurs", b =>
                {
                    b.Property<int>("ActeurId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("ActeurId");

                    b.ToTable("Acteurs");
                });

            modelBuilder.Entity("GestionDVDs.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UtilisateurId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GestionDVDs.Models.Categories", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategorieId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GestionDVDs.Models.EmpruntsFilms", b =>
                {
                    b.Property<int>("ExemplaireId");

                    b.Property<DateTime>("DateEmprunt")
                        .HasColumnType("datetime");

                    b.Property<string>("UtilisateurId")
                        .IsRequired();

                    b.HasKey("ExemplaireId");

                    b.HasAlternateKey("ExemplaireId", "UtilisateurId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("EmpruntsFilms");
                });

            modelBuilder.Entity("GestionDVDs.Models.Exemplaires", b =>
                {
                    b.Property<int>("ExemplaireId");

                    b.Property<string>("UtilisateurProprietaireId")
                        .IsRequired();

                    b.HasKey("ExemplaireId");

                    b.HasIndex("UtilisateurProprietaireId");

                    b.ToTable("Exemplaires");
                });

            modelBuilder.Entity("GestionDVDs.Models.Films", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int?>("AnneeSortie");

                    b.Property<int?>("Categorie");

                    b.Property<DateTime>("DateMaj")
                        .HasColumnName("DateMAJ")
                        .HasColumnType("datetime");

                    b.Property<int?>("DureeMinutes");

                    b.Property<int?>("FilmOriginal");

                    b.Property<int?>("Format");

                    b.Property<string>("ImagePochette")
                        .HasMaxLength(50);

                    b.Property<int?>("NbDisques");

                    b.Property<int?>("ProducteurId");

                    b.Property<int?>("RealisateurId");

                    b.Property<string>("Resume")
                        .HasMaxLength(500);

                    b.Property<string>("TitreFrancais")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TitreOriginal")
                        .HasMaxLength(50);

                    b.Property<string>("UtilisateurMajid")
                        .IsRequired()
                        .HasColumnName("UtilisateurMAJId");

                    b.Property<bool?>("VersionEtendue");

                    b.Property<string>("Xtra")
                        .IsRequired()
                        .HasColumnName("XTra")
                        .HasMaxLength(255);

                    b.HasKey("FilmId");

                    b.HasIndex("Categorie");

                    b.HasIndex("Format");

                    b.HasIndex("ProducteurId");

                    b.HasIndex("RealisateurId");

                    b.HasIndex("UtilisateurMajid");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsActeurs", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("ActeurId");

                    b.HasKey("FilmId", "ActeurId");

                    b.HasAlternateKey("ActeurId", "FilmId");

                    b.ToTable("FilmsActeurs");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsLangues", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("LangueId");

                    b.HasKey("FilmId", "LangueId");

                    b.HasIndex("LangueId");

                    b.ToTable("FilmsLangues");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsSousTitres", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("SousTitreId");

                    b.HasKey("FilmId", "SousTitreId");

                    b.HasIndex("SousTitreId");

                    b.ToTable("FilmsSousTitres");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsSupplements", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("SupplementId");

                    b.HasKey("FilmId", "SupplementId");

                    b.HasIndex("SupplementId");

                    b.ToTable("FilmsSupplements");
                });

            modelBuilder.Entity("GestionDVDs.Models.Formats", b =>
                {
                    b.Property<int>("FormatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("FormatId");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("GestionDVDs.Models.Langues", b =>
                {
                    b.Property<int>("LangueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Langue")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("LangueId");

                    b.ToTable("Langues");
                });

            modelBuilder.Entity("GestionDVDs.Models.Preferences", b =>
                {
                    b.Property<int>("PreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PreferenceId");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("GestionDVDs.Models.Producteurs", b =>
                {
                    b.Property<int>("ProducteurId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ProducteurId");

                    b.ToTable("Producteurs");
                });

            modelBuilder.Entity("GestionDVDs.Models.Realisateurs", b =>
                {
                    b.Property<int>("RealisateurId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RealisateurId");

                    b.ToTable("Realisateurs");
                });

            modelBuilder.Entity("GestionDVDs.Models.SousTitres", b =>
                {
                    b.Property<int>("SousTitreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LangueSousTitre")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("SousTitreId");

                    b.ToTable("SousTitres");
                });

            modelBuilder.Entity("GestionDVDs.Models.Supplements", b =>
                {
                    b.Property<int>("SupplementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SupplementId");

                    b.ToTable("Supplements");
                });

            modelBuilder.Entity("GestionDVDs.Models.TypesUtilisateur", b =>
                {
                    b.Property<string>("TypeUtilisateur")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasMaxLength(1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TypeUtilisateur");

                    b.ToTable("TypesUtilisateur");
                });

            modelBuilder.Entity("GestionDVDs.Models.Utilisateurs", b =>
                {
                    b.Property<int>("UtilisateurId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MotPasse");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("TypeUtilisateur")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasMaxLength(1);

                    b.HasKey("UtilisateurId");

                    b.HasIndex("TypeUtilisateur");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("GestionDVDs.Models.UtilisateursPreferences", b =>
                {
                    b.Property<string>("UtilisateurId");

                    b.Property<int>("PreferenceId");

                    b.Property<string>("Valeur")
                        .HasMaxLength(50);

                    b.HasKey("UtilisateurId", "PreferenceId");

                    b.HasAlternateKey("PreferenceId", "UtilisateurId");

                    b.ToTable("UtilisateursPreferences");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GestionDVDs.Models.EmpruntsFilms", b =>
                {
                    b.HasOne("GestionDVDs.Models.ApplicationUser", "Utilisateur")
                        .WithMany("EmpruntsFilms")
                        .HasForeignKey("UtilisateurId")
                        .HasConstraintName("FK__EmpruntsF__Utili__49E3F248");
                });

            modelBuilder.Entity("GestionDVDs.Models.Exemplaires", b =>
                {
                    b.HasOne("GestionDVDs.Models.ApplicationUser", "UtilisateurProprietaire")
                        .WithMany("Exemplaires")
                        .HasForeignKey("UtilisateurProprietaireId")
                        .HasConstraintName("FK__Exemplair__Utili__4CC05EF3");
                });

            modelBuilder.Entity("GestionDVDs.Models.Films", b =>
                {
                    b.HasOne("GestionDVDs.Models.Categories", "CategorieNavigation")
                        .WithMany("Films")
                        .HasForeignKey("Categorie")
                        .HasConstraintName("FK__Films__Categorie__4F9CCB9E");

                    b.HasOne("GestionDVDs.Models.Formats", "FormatNavigation")
                        .WithMany("Films")
                        .HasForeignKey("Format")
                        .HasConstraintName("FK__Films__Format__5090EFD7");

                    b.HasOne("GestionDVDs.Models.Producteurs", "Producteur")
                        .WithMany("Films")
                        .HasForeignKey("ProducteurId")
                        .HasConstraintName("FK__Films__Producteu__536D5C82");

                    b.HasOne("GestionDVDs.Models.Realisateurs", "Realisateur")
                        .WithMany("Films")
                        .HasForeignKey("RealisateurId")
                        .HasConstraintName("FK__Films__Realisate__52793849");

                    b.HasOne("GestionDVDs.Models.ApplicationUser", "UtilisateurMaj")
                        .WithMany("Films")
                        .HasForeignKey("UtilisateurMajid")
                        .HasConstraintName("FK__Films__Utilisate__51851410");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsActeurs", b =>
                {
                    b.HasOne("GestionDVDs.Models.Acteurs", "Acteur")
                        .WithMany("FilmsActeurs")
                        .HasForeignKey("ActeurId")
                        .HasConstraintName("FK__FilmsActe__Acteu__573DED66");

                    b.HasOne("GestionDVDs.Models.Films", "Film")
                        .WithMany("FilmsActeurs")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmsActe__FilmI__5649C92D");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsLangues", b =>
                {
                    b.HasOne("GestionDVDs.Models.Films", "Film")
                        .WithMany("FilmsLangues")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmsLang__FilmI__5A1A5A11");

                    b.HasOne("GestionDVDs.Models.Langues", "Langue")
                        .WithMany("FilmsLangues")
                        .HasForeignKey("LangueId")
                        .HasConstraintName("FK__FilmsLang__Langu__5B0E7E4A");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsSousTitres", b =>
                {
                    b.HasOne("GestionDVDs.Models.Films", "Film")
                        .WithMany("FilmsSousTitres")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmsSous__FilmI__5DEAEAF5");

                    b.HasOne("GestionDVDs.Models.SousTitres", "SousTitre")
                        .WithMany("FilmsSousTitres")
                        .HasForeignKey("SousTitreId")
                        .HasConstraintName("FK__FilmsSous__SousT__5EDF0F2E");
                });

            modelBuilder.Entity("GestionDVDs.Models.FilmsSupplements", b =>
                {
                    b.HasOne("GestionDVDs.Models.Films", "Film")
                        .WithMany("FilmsSupplements")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmsSupp__FilmI__61BB7BD9");

                    b.HasOne("GestionDVDs.Models.Supplements", "Supplement")
                        .WithMany("FilmsSupplements")
                        .HasForeignKey("SupplementId")
                        .HasConstraintName("FK__FilmsSupp__Suppl__62AFA012");
                });

            modelBuilder.Entity("GestionDVDs.Models.Utilisateurs", b =>
                {
                    b.HasOne("GestionDVDs.Models.TypesUtilisateur", "TypeUtilisateurNavigation")
                        .WithMany("Utilisateurs")
                        .HasForeignKey("TypeUtilisateur")
                        .HasConstraintName("FK__Utilisate__TypeU__4336F4B9");
                });

            modelBuilder.Entity("GestionDVDs.Models.UtilisateursPreferences", b =>
                {
                    b.HasOne("GestionDVDs.Models.Preferences", "Preference")
                        .WithMany("UtilisateursPreferences")
                        .HasForeignKey("PreferenceId")
                        .HasConstraintName("FK__Utilisate__Prefe__4707859D");

                    b.HasOne("GestionDVDs.Models.ApplicationUser", "Utilisateur")
                        .WithMany("UtilisateursPreferences")
                        .HasForeignKey("UtilisateurId")
                        .HasConstraintName("FK__Utilisate__Utili__46136164");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GestionDVDs.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GestionDVDs.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GestionDVDs.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GestionDVDs.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
