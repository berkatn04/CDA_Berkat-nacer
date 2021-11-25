﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("WebApplication1.Data.Models.Personnes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Age")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("WebApplication1.Data.Models.Voitures", b =>
                {
                    b.Property<int>("IdVoiture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Marque")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Modele")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("PersonnesId")
                        .HasColumnType("int");

                    b.HasKey("IdVoiture");

                    b.HasIndex("PersonnesId");

                    b.ToTable("Voiture");
                });

            modelBuilder.Entity("WebApplication1.Data.Models.Voitures", b =>
                {
                    b.HasOne("WebApplication1.Data.Models.Personnes", null)
                        .WithMany("Voiture")
                        .HasForeignKey("PersonnesId");
                });

            modelBuilder.Entity("WebApplication1.Data.Models.Personnes", b =>
                {
                    b.Navigation("Voiture");
                });
#pragma warning restore 612, 618
        }
    }
}
