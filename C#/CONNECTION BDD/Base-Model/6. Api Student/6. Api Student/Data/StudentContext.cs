using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _6._Api_Student.Data.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Participation> Participation { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.IdCourse)
                    .HasName("PRIMARY");

                entity.ToTable("courses");

                entity.Property(e => e.IdCourse).HasColumnType("int(11)");

                entity.Property(e => e.NomCourse).HasMaxLength(50);
            });

            modelBuilder.Entity<Participation>(entity =>
            {
                entity.HasKey(e => e.IdParticipation)
                    .HasName("PRIMARY");

                entity.ToTable("participation");

                entity.HasIndex(e => e.IdCourse, "FK_Participation_Courses");

                entity.HasIndex(e => e.IdStudent, "FK_Participation_Students");

                entity.Property(e => e.IdParticipation).HasColumnType("int(11)");

                entity.Property(e => e.IdCourse).HasColumnType("int(11)");

                entity.Property(e => e.IdStudent).HasColumnType("int(11)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ListParticipation)
                    .HasForeignKey(d => d.IdCourse)
                    .HasConstraintName("FK_Participation_Courses");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ListParticipation)
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK_Participation_Students");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdStudent)
                    .HasName("PRIMARY");

                entity.ToTable("students");

                entity.Property(e => e.IdStudent).HasColumnType("int(11)");

                entity.Property(e => e.AgeStudent).HasColumnType("int(11)");

                entity.Property(e => e.NomStudent).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
