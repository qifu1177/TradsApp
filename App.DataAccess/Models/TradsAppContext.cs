using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.DataAccess.Models
{
    public partial class TradsAppContext : DbContext
    {
        public TradsAppContext()
        {
        }

        public TradsAppContext(DbContextOptions<TradsAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeTrade> EmployeeTrades { get; set; } = null!;
        public virtual DbSet<TradDatum> TradData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeTrade>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("EmployeeTrade");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Employee).HasMaxLength(100);

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .HasColumnName("ISIN");

                entity.Property(e => e.Volumen).HasColumnName("VOLUMEN");
            });

            modelBuilder.Entity<TradDatum>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VolumeCumEuro).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VolumeEuro).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
