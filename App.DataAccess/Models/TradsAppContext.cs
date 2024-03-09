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

        public virtual DbSet<Dbuser> Dbusers { get; set; } = null!;
        public virtual DbSet<DbuserGroup> DbuserGroups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TradsApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dbuser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DBUser");

                entity.HasIndex(e => e.Oid, "IX_DBUser")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(50)
                    .HasColumnName("OID");

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.UserGroupId).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.Dbusers)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBUser_DBUserGroup");
            });

            modelBuilder.Entity<DbuserGroup>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DBUserGroup");

                entity.Property(e => e.Oid)
                    .HasMaxLength(50)
                    .HasColumnName("OID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
