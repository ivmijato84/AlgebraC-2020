﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Fakultet.Models
{
    public partial class BazaPoklonaContext : DbContext
    {
        public BazaPoklonaContext()
        {
        }

        public BazaPoklonaContext(DbContextOptions<BazaPoklonaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Poklon> Poklons { get; set; }
        public virtual DbSet<Trgovina> Trgovinas { get; set; }
        public virtual DbSet<VrstaRobe> VrstaRobes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BazaPoklona;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_CI_AS");

            modelBuilder.Entity<Poklon>(entity =>
            {
                entity.HasKey(e => e.IdPoklon)
                    .HasName("PK__Poklon__2D443D4D8B605116");

                entity.ToTable("Poklon");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.VrstaRobeNavigation)
                    .WithMany(p => p.Poklons)
                    .HasForeignKey(d => d.VrstaRobe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poklon__VrstaRob__286302EC");
            });

            modelBuilder.Entity<Trgovina>(entity =>
            {
                entity.HasKey(e => e.IdTrgovina)
                    .HasName("PK__Trgovina__A4127670E8BFD426");

                entity.ToTable("Trgovina");

                entity.Property(e => e.NazivTrgovina)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.VrstaRobeNavigation)
                    .WithMany(p => p.Trgovinas)
                    .HasForeignKey(d => d.VrstaRobe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trgovina__VrstaR__29572725");
            });

            modelBuilder.Entity<VrstaRobe>(entity =>
            {
                entity.ToTable("VrstaRobe");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
