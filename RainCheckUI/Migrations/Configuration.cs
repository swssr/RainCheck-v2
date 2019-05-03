namespace RainCheckUI.Migrations
{
    using RainCheckUI.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RainCheckUI.Model.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RainCheckUI.Model.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "Gauteng" });
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "Kwa-Zulu Natal" });
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "Eastern Cape" });
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "Western Cape" });
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "Northern Cape" });
            context.Provinces.AddOrUpdate(new Province() { ProvinceName = "North West" });

            //context.Cities.AddOrUpdate(new City() { CityName = "Jorburg", ProvinceId = 1 });
            //context.Cities.AddOrUpdate(new City() { CityName = "Durban", ProvinceId = 2 });
            //context.Cities.AddOrUpdate(new City() { CityName = "Bizana", ProvinceId = 3 });
            //context.Cities.AddOrUpdate(new City() { CityName = "Durbanville", ProvinceId = 4 });
            //context.Cities.AddOrUpdate(new City() { CityName = "Hoorster", ProvinceId = 5 });
            //context.Cities.AddOrUpdate(new City() { CityName = "Limpopo", ProvinceId = 6 });

            //context.Users.AddOrUpdate(new User() { Username = "admin", Password = "Password01", CityId = 3, isAdmin = true });

            context.SaveChanges();
        }
    }
}
