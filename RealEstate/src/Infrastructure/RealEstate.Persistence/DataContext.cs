using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entities;

namespace RealEstate.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) 
            : base(options) { }

        public DataContext()
            : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=true;App=Real Estate Api;\r\n", sqlServerOptions =>
            {
                sqlServerOptions.CommandTimeout(15);
                sqlServerOptions.MigrationsHistoryTable("MigrationsHistory");
            });

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<City> Cities { get; set; }
    }
}
