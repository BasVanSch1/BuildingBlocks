using API.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using API.Models;

namespace API.Database
{
    public class SQLServerDatabaseContext : DbContext
    {
        private readonly IOptions<AppSettings> _appSettings;

        // Default constructor for dependency injection
        public SQLServerDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_appSettings.Value.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<API.Models.Customer> Customer { get; set; } = default!;
        public DbSet<API.Models.Order> Order { get; set; } = default!;
        public DbSet<API.Models.Product> Product { get; set; } = default!;
    }
}
