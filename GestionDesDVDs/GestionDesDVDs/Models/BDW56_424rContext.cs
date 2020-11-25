using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionDesDVDs.Models
{
    public partial class BDW56_424rContext : DbContext
    {
        public BDW56_424rContext()
        {
        }

        public BDW56_424rContext(DbContextOptions<BDW56_424rContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acteurs> Acteurs { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<EmpruntsFilms> EmpruntsFilms { get; set; }
        public virtual DbSet<Exemplaires> Exemplaires { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<FilmsActeurs> FilmsActeurs { get; set; }
        public virtual DbSet<FilmsLangues> FilmsLangues { get; set; }
        public virtual DbSet<FilmsSousTitres> FilmsSousTitres { get; set; }
        public virtual DbSet<FilmsSupplements> FilmsSupplements { get; set; }
        public virtual DbSet<Formats> Formats { get; set; }
        public virtual DbSet<Langues> Langues { get; set; }
        public virtual DbSet<Preferences> Preferences { get; set; }
        public virtual DbSet<Producteurs> Producteurs { get; set; }
        public virtual DbSet<Realisateurs> Realisateurs { get; set; }
        public virtual DbSet<SousTitres> SousTitres { get; set; }
        public virtual DbSet<Supplements> Supplements { get; set; }
        public virtual DbSet<TypesUtilisateur> TypesUtilisateur { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
        public virtual DbSet<UtilisateursPreferences> UtilisateursPreferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=tcp:424sql.cgodin.qc.ca,5433;Database=BDW56_424r;Trusted_Connection=True;User ID=W56equipe424r; Password=Secret36512;Integrated Security=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acteurs>(entity =>
            {
                entity.HasKey(e => e.NoActeur);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.NoCategorie);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmpruntsFilms>(entity =>
            {
                entity.HasKey(e => e.NoExemplaire);

                entity.Property(e => e.NoExemplaire).ValueGeneratedNever();

                entity.Property(e => e.DateEmprunt).HasColumnType("datetime");

                entity.HasOne(d => d.NoUtilisateurNavigation)
                    .WithMany(p => p.EmpruntsFilms)
                    .HasForeignKey(d => d.NoUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpruntsF__NoUti__0EC32C7A");
            });

            modelBuilder.Entity<Exemplaires>(entity =>
            {
                entity.HasKey(e => e.NoExemplaire);

                entity.Property(e => e.NoExemplaire).ValueGeneratedNever();

                entity.HasOne(d => d.NoUtilisateurProprietaireNavigation)
                    .WithMany(p => p.Exemplaires)
                    .HasForeignKey(d => d.NoUtilisateurProprietaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Exemplair__NoUti__119F9925");
            });

            modelBuilder.Entity<Films>(entity =>
            {
                entity.HasKey(e => e.FilmId);

                entity.Property(e => e.FilmId).ValueGeneratedNever();

                entity.Property(e => e.DateMaj)
                    .HasColumnName("DateMAJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImagePochette).HasMaxLength(50);

                entity.Property(e => e.NoUtilisateurMaj).HasColumnName("NoUtilisateurMAJ");

                entity.Property(e => e.Resume).HasMaxLength(500);

                entity.Property(e => e.TitreFrancais)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TitreOriginal).HasMaxLength(50);

                entity.Property(e => e.Xtra)
                    .IsRequired()
                    .HasColumnName("XTra")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CategorieNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.Categorie)
                    .HasConstraintName("FK__Films__Categorie__147C05D0");

                entity.HasOne(d => d.FormatNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.Format)
                    .HasConstraintName("FK__Films__Format__15702A09");

                entity.HasOne(d => d.NoProducteurNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoProducteur)
                    .HasConstraintName("FK__Films__NoProduct__184C96B4");

                entity.HasOne(d => d.NoRealisateurNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoRealisateur)
                    .HasConstraintName("FK__Films__NoRealisa__1758727B");

                entity.HasOne(d => d.NoUtilisateurMajNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoUtilisateurMaj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Films__NoUtilisa__16644E42");
            });

            modelBuilder.Entity<FilmsActeurs>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.NoActeur });

                entity.HasOne(d => d.NoActeurNavigation)
                    .WithMany(p => p.FilmsActeurs)
                    .HasForeignKey(d => d.NoActeur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsActe__NoAct__1C1D2798");

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsActeurs)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsActe__NoFil__1B29035F");
            });

            modelBuilder.Entity<FilmsLangues>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.NoLangue });

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsLangues)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsLang__NoFil__1EF99443");

                entity.HasOne(d => d.NoLangueNavigation)
                    .WithMany(p => p.FilmsLangues)
                    .HasForeignKey(d => d.NoLangue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsLang__NoLan__1FEDB87C");
            });

            modelBuilder.Entity<FilmsSousTitres>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.NoSousTitre });

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsSousTitres)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSous__NoFil__22CA2527");

                entity.HasOne(d => d.NoSousTitreNavigation)
                    .WithMany(p => p.FilmsSousTitres)
                    .HasForeignKey(d => d.NoSousTitre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSous__NoSou__23BE4960");
            });

            modelBuilder.Entity<FilmsSupplements>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.NoSupplement });

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsSupplements)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSupp__NoFil__269AB60B");

                entity.HasOne(d => d.NoSupplementNavigation)
                    .WithMany(p => p.FilmsSupplements)
                    .HasForeignKey(d => d.NoSupplement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSupp__NoSup__278EDA44");
            });

            modelBuilder.Entity<Formats>(entity =>
            {
                entity.HasKey(e => e.NoFormat);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Langues>(entity =>
            {
                entity.HasKey(e => e.NoLangue);

                entity.Property(e => e.Langue)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Preferences>(entity =>
            {
                entity.HasKey(e => e.NoPreference);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Producteurs>(entity =>
            {
                entity.HasKey(e => e.NoProducteur);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Realisateurs>(entity =>
            {
                entity.HasKey(e => e.NoRealisateur);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SousTitres>(entity =>
            {
                entity.HasKey(e => e.NoSousTitre);

                entity.Property(e => e.LangueSousTitre)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Supplements>(entity =>
            {
                entity.HasKey(e => e.NoSupplement);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypesUtilisateur>(entity =>
            {
                entity.HasKey(e => e.TypeUtilisateur);

                entity.Property(e => e.TypeUtilisateur)
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Utilisateurs>(entity =>
            {
                entity.HasKey(e => e.NoUtilisateur);

                entity.Property(e => e.Courriel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomUtilisateur)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TypeUtilisateur)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.TypeUtilisateurNavigation)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(d => d.TypeUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilisate__TypeU__08162EEB");
            });

            modelBuilder.Entity<UtilisateursPreferences>(entity =>
            {
                entity.HasKey(e => new { e.NoUtilisateur, e.NoPreference });

                entity.Property(e => e.Valeur).HasMaxLength(50);

                entity.HasOne(d => d.NoPreferenceNavigation)
                    .WithMany(p => p.UtilisateursPreferences)
                    .HasForeignKey(d => d.NoPreference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilisate__NoPre__0BE6BFCF");

                entity.HasOne(d => d.NoUtilisateurNavigation)
                    .WithMany(p => p.UtilisateursPreferences)
                    .HasForeignKey(d => d.NoUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilisate__NoUti__0AF29B96");
            });
        }
    }
}
