using System.Data.Entity.Migrations;
using CarRentalApp.Persistence;

namespace CarRentalApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CarRentalAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarRentalAppContext context)
        {
            var initializer = new CarRentalDbInitializer();
            initializer.InitializeDatabase(context);
        }
    }
}
