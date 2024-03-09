
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
    }
}
