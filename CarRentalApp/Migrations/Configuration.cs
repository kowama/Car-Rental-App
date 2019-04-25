using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using CarRentalApp.Core.domain;
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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var administratorRole = new Role
            {
                Name = RoleName.ADMINISTRATOR,
                Description = "The big boss in less words"
            };

            var managerRole = new Role
            {
                Name = RoleName.MANAGER,
                Description = "The manager is the person Who Handle Client and Rents"
            };

            context.Roles.AddOrUpdate(r=>r.Name,
                administratorRole,
                managerRole);


            context.Users.AddOrUpdate(u => u.Username,
                new User
                {
                    Username = "kowama",
                    FirstName = "Latif",
                    LastName = "Karambiri",
                    Cin = "L002257P",
                    Email = "n.kowama@gmail.com",
                    Phone = "0691025223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        administratorRole
                    }
                },
                new User
                {
                    Username = "Medi1",
                    FirstName = "Mehdi",
                    LastName = "Lahk",
                    Cin = "C002057P",
                    Email = "l.mehdi@gmail.com",
                    Phone = "0691889223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                },
                new User
                {
                    Username = "KoyeKoye",
                    FirstName = "Verassou",
                    LastName = "Koye",
                    Cin = "L002297P",
                    Email = "kverassou7@gmail.com",
                    Phone = "069104223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                }

        );
    }

    }
}
