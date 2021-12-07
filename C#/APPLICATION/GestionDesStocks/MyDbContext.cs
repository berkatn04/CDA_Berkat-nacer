using GestionDesStocks.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Categories> Categorie { get; set; }
        public virtual DbSet<TypeProduits> TypeProduit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=stock;port=3306;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCategories, "FK_Article_Categories");

                entity.Property(e => e.IdArticle).HasColumnType("int(11)");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.LibelleArticle).HasMaxLength(100);

                entity.Property(e => e.QuantiteStockee).HasColumnType("int(11)");

                entity.HasOne(d => d.Categorie)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.IdCategories)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Article_Categories");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.IdCategories)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdTypeProduits, "FK_Categories_TypeProduits");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.IdTypeProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleCategorie).HasMaxLength(100);

                entity.HasOne(d => d.TypeProduit)
                    .WithMany(p => p.Categorie)
                    .HasForeignKey(d => d.IdTypeProduits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_TypeProduits");
            });

            modelBuilder.Entity<TypeProduits>(entity =>
            {
                entity.HasKey(e => e.IdTypeProduits)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdTypeProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleTypeProduit).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
