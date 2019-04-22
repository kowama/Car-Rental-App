using System.Collections.ObjectModel;
using System.Linq;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Migrations
{
    
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Persistence.CarRentalAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Persistence.CarRentalAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var administratorRole = new Role()
            {
                Name = RoleName.ADMINISTRATOR,
                Description = "The big boss in less words"
            };

            var managerRole = new Role()
            {
                Name = RoleName.MANAGER,
                Description = "The manager is the person Who Handle Client and Rents"
            };

            context.Roles.AddOrUpdate(administratorRole);
            context.Roles.AddOrUpdate(managerRole);


            context.Users.AddOrUpdate(u => u.Username,
                new User()
                {
                    Username = "kowama",
                    FirstName = "Latif",
                    LastName = "Karambiri",
                    Email = "n.kowama@gmail.com",
                    Phone = "0691025223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>()
                    {
//                        context.Roles.Single(r=>r.Name == RoleName.ADMINISTRATOR)
                        administratorRole
                    }
                });
        }

    }
}
