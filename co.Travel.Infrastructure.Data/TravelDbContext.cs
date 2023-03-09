using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace co.Travel.Infrastructure.Data
{
    public class TravelDbContext : IdentityDbContext
    {

        public TravelDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //**** Solo para Realizarel Primer Initial-Migration  ****
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("dbConnection"));
                optionsBuilder.UseSqlServer("name=dbConnection");
            }
        }

        public virtual DbSet<Autor> Autores { get; set; }

        public virtual DbSet<AutoresLibro> AutoresLibros { get; set; }

        public virtual DbSet<Editorial> Editoriales { get; set; }

        public virtual DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Autores");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(45)
                    .IsUnicode(false);
                entity.Property(e => e.Nombres)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nombres");
            });

            modelBuilder.Entity<AutoresLibro>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_AutoresLibro");

                entity.Property(e => e.AutoresId).HasColumnName("AutoresId");
                entity.Property(e => e.LibrosIsbn).HasColumnName("LibrosIsbn");

                entity.HasOne(d => d.Autores).WithMany(p => p.AutoresLibros)
                    .HasForeignKey(d => d.AutoresId)
                    .HasConstraintName("FK_AutoresLibro_autor");

                entity.HasOne(d => d.LibroIsbn).WithMany(p => p.AutoresLibros)
                    .HasForeignKey(d => d.LibrosIsbn)
                    .HasConstraintName("FK_AutoresLibro_libro");
            });


            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Editorial");

                entity.Property(e => e.Id);

                entity.Property(e => e.Sede)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("sede");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Libros");

                entity.Property(e => e.Id)
                    .HasColumnName("ISBN");
                entity.Property(e => e.EditoresId).HasColumnName("Editores_id");
                entity.Property(e => e.NPaginas)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("n_paginas");
                entity.Property(e => e.Sinopsis)
                    .HasColumnType("text")
                    .HasColumnName("sinopsis");
                entity.Property(e => e.Titulo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Editores).WithMany(p => p.Libros)
                    .HasForeignKey(d => d.EditoresId)
                    .HasConstraintName("FK_Libros_Editores");
            });

            base.OnModelCreating(modelBuilder);
        }
 
    }
}
