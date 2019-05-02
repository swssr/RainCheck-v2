using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace RainCheckUI.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Forecast> Forecasts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasRequired(c => c.Province)
                .WithMany()
                .WillCascadeOnDelete(true);
        }
    }
}
