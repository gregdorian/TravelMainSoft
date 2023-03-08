using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Domain.Entities;

namespace co.Travel.Infrastructure.Data
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Autor> Autores { get; set; }

        public virtual DbSet<AutoresLibro> AutoresLibros { get; set; }

        public virtual DbSet<Editorial> Editoriales { get; set; }

        public virtual DbSet<Libro> Libros { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Autore>(entity =>
        //    {
        //        entity.HasKey(e => e.Id).HasName("PK__Autores__3213E83FCB905200");

        //        entity.Property(e => e.Id)
        //            .ValueGeneratedNever()
        //            .HasColumnName("id");
        //        entity.Property(e => e.Apellidos)
        //            .HasMaxLength(45)
        //            .IsUnicode(false);
        //        entity.Property(e => e.Nombres)
        //            .HasMaxLength(45)
        //            .IsUnicode(false)
        //            .HasColumnName("nombres");
        //    });

        //    modelBuilder.Entity<AutoresLibro>(entity =>
        //    {
        //        entity.HasKey(e => e.AutoresLibrosId).HasName("PK__AutoresL__047B18FD03FE45F8");

        //        entity.Property(e => e.AutoresLibrosId)
        //            .ValueGeneratedNever()
        //            .HasColumnName("AutoresLibrosID");
        //        entity.Property(e => e.AutoresId).HasColumnName("autores_id");
        //        entity.Property(e => e.LibrosIsbn).HasColumnName("libros_ISBN");

        //        entity.HasOne(d => d.Autores).WithMany(p => p.AutoresLibros)
        //            .HasForeignKey(d => d.AutoresId)
        //            .HasConstraintName("FK__AutoresLi__autor__2E1BDC42");

        //        entity.HasOne(d => d.LibrosIsbnNavigation).WithMany(p => p.AutoresLibros)
        //            .HasForeignKey(d => d.LibrosIsbn)
        //            .HasConstraintName("FK__AutoresLi__libro__2F10007B");
        //    });

        //    modelBuilder.Entity<Editoriale>(entity =>
        //    {
        //        entity.HasKey(e => e.Id).HasName("PK__Editoria__3213E83F472ABA3E");

        //        entity.Property(e => e.Id)
        //            .ValueGeneratedNever()
        //            .HasColumnName("id");
        //        entity.Property(e => e.Sede)
        //            .HasMaxLength(45)
        //            .IsUnicode(false)
        //            .HasColumnName("sede");
        //    });

        //    modelBuilder.Entity<Libro>(entity =>
        //    {
        //        entity.HasKey(e => e.Isbn).HasName("PK__Libros__447D36EBD42157B1");

        //        entity.Property(e => e.Isbn)
        //            .ValueGeneratedNever()
        //            .HasColumnName("ISBN");
        //        entity.Property(e => e.EditoresId).HasColumnName("Editores_id");
        //        entity.Property(e => e.NPaginas)
        //            .HasMaxLength(45)
        //            .IsUnicode(false)
        //            .HasColumnName("n_paginas");
        //        entity.Property(e => e.Sinopsis)
        //            .HasColumnType("text")
        //            .HasColumnName("sinopsis");
        //        entity.Property(e => e.Titulo)
        //            .HasMaxLength(45)
        //            .IsUnicode(false);

        //        entity.HasOne(d => d.Editores).WithMany(p => p.Libros)
        //            .HasForeignKey(d => d.EditoresId)
        //            .HasConstraintName("FK__Libros__Editores__2D27B809");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
