using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class etudiantContext : DbContext
    {
        public etudiantContext()
        {
        }

        public etudiantContext(DbContextOptions<etudiantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cour> Cours { get; set; }
        public virtual DbSet<Etudiant> Etudiants { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Participation> Participations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=def");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cour>(entity =>
            {
                entity.HasKey(e => e.IdCours)
                    .HasName("PRIMARY");

                entity.ToTable("cours");

                entity.Property(e => e.IdCours).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NomCours).HasMaxLength(50);
            });

            modelBuilder.Entity<Etudiant>(entity =>
            {
                entity.HasKey(e => e.IdEtudiant)
                    .HasName("PRIMARY");

                entity.ToTable("etudiant");

                entity.HasIndex(e => e.IdGrade, "IdGrade");

                entity.Property(e => e.IdEtudiant).HasColumnType("int(11)");

                entity.Property(e => e.IdGrade).HasColumnType("int(11)");

                entity.Property(e => e.Nom).HasMaxLength(50);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.IdGrade)
                    .HasName("PRIMARY");

                entity.ToTable("grade");

                entity.Property(e => e.IdGrade).HasColumnType("int(32)");

                entity.Property(e => e.NomGrade)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Participation>(entity =>
            {
                entity.HasKey(e => e.IdParticipation)
                    .HasName("PRIMARY");

                entity.ToTable("participation");

                entity.HasIndex(e => e.IdCours, "IdCours");

                entity.HasIndex(e => e.IdEtudiant, "IdEtudiant");

                entity.Property(e => e.IdParticipation).HasColumnType("int(11)");

                entity.Property(e => e.IdCours).HasColumnType("int(11)");

                entity.Property(e => e.IdEtudiant).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
