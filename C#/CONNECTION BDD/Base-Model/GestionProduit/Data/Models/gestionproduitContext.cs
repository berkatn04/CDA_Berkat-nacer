using System;
using GestionProduit.Data.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionProduit.Data.Models
{
    public partial class gestionproduitContext : DbContext
    {
        public gestionproduitContext()
        {
        }

        public gestionproduitContext(DbContextOptions<gestionproduitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Preparation> Preparations { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=def");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commandes");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Preparation>(entity =>
            {
                entity.HasKey(e => e.IdPreparation)
                    .HasName("PRIMARY");

                entity.ToTable("preparation");

                entity.HasIndex(e => e.IdCommande, "FK_Preparation_Commandes");

                entity.HasIndex(e => e.IdProduit, "FK_Preparation_Produit");

                entity.Property(e => e.IdPreparation).HasColumnType("int(11)");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.HasOne(d => d.Commande)
                    .WithMany(p => p.Preparation)
                    .HasForeignKey(d => d.IdCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preparation_Commandes");

                entity.HasOne(d => d.Produit)
                    .WithMany(p => p.Preparation)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preparation_Produit");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.IdProduit)
                    .HasName("PRIMARY");

                entity.ToTable("produit");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.LibelleProduit).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
