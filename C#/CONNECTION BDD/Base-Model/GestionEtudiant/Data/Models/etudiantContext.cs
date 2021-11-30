using System;
using GestionEtudiant.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Test.Data.Models
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

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Etudiants)
                    .HasForeignKey(d => d.IdGrade)
                    .HasConstraintName("Fk_Etudiant_Grade");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.IdGrade)
                    .HasName("PRIMARY");

                entity.ToTable("grade");

                entity.Property(e => e.IdGrade).HasColumnType("int(32)");

                entity.Property(e => e.NomGrade).HasMaxLength(250);
            });

            modelBuilder.Entity<Participation>(entity =>
            {
                entity.HasKey(e => e.IdParticipation)
                    .HasName("PRIMARY");

                entity.ToTable("participation");

                entity.HasIndex(e => e.IdCours, "FK_participation_Cours");

                entity.HasIndex(e => e.IdEtudiant, "FK_participation_Etudiant");

                entity.Property(e => e.IdParticipation).HasColumnType("int(11)");

                entity.Property(e => e.IdCours).HasColumnType("int(11)");

                entity.Property(e => e.IdEtudiant).HasColumnType("int(11)");

                entity.HasOne(d => d.Cours)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdCours)
                    .HasConstraintName("FK_participation_Cours");

                entity.HasOne(d => d.Etudiant)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdEtudiant)
                    .HasConstraintName("FK_participation_Etudiant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
