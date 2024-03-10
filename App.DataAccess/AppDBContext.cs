
using App.DataAccess.Models;
using App.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;


namespace App.DataAccess
{
    public class AppDBContext : TradsAppContext
    {
        private Config _config;
        public AppDBContext(Config config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TablePrivileges>(entity =>
            {
                entity.HasKey(e => e.PRIVILEGE_TYPE);
            });

           base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<TablePrivileges> DbSetTablePrivileges { get; set; } = null!;
    }
}
