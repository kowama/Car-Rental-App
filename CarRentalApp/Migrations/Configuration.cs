using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.IO;
using System.Linq;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.domain.SeedData;
using CarRentalApp.Persistence;
using CsvHelper;

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
            var administratorRole = new Role
            {
                Name = RoleName.Administrator,
                Description = "The big boss in less words"
            };

            var managerRole = new Role
            {
                Name = RoleName.Manager,
                Description = "The manager is the person Who Handle Client and Rents"
            };

            context.Roles.AddOrUpdate(r => r.Name,
                administratorRole,
                managerRole);


            context.Users.AddOrUpdate(u => u.Username,
                new User
                {
                    Username = "admin",
                    FirstName = "John",
                    LastName = "Doe",
                    Cin = "L099057P",
                    Email = "john.doe@gmail.com",
                    Phone = "+212691025223",
                    Password = "123456",
                    Roles = new ObservableCollection<Role>
                    {
                        administratorRole
                    }
                },
                new User
                {
                    Username = "manager1",
                    FirstName = "Sieg",
                    LastName = "Jager",
                    Cin = "C002057P",
                    Email = "j.jager@gmail.com",
                    Phone = "212691025223",
                    Password = "123456",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                },
                new User
                {
                    Username = "manager2",
                    FirstName = "John",
                    LastName = "Turner",
                    Cin = "L002297P",
                    Email = "john.turner@gmail.com",
                    Phone = "0691042236",
                    Password = "123456",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                });

            /**insertion of somme default data**/
            if (!Convert.ToBoolean(ConfigurationManager.AppSettings["FeedWithData"])) return;
            //Clients
            var reader = new StreamReader(ResourcePaths.Clients);
            var csv = new CsvReader(reader);
            csv.Configuration.Delimiter = ",";
            csv.Configuration.CultureInfo = CultureInfo.InvariantCulture;
            csv.Configuration.RegisterClassMap<ClientMap>();
            var clientsRecords = csv.GetRecords<Client>().ToArray();
            context.Clients.AddOrUpdate(c => c.Cin, clientsRecords);
            //Classifications
            reader = new StreamReader(ResourcePaths.Classifications);
            csv = new CsvReader(reader);
            csv.Configuration.Delimiter = ",";
            csv.Configuration.CultureInfo = CultureInfo.InvariantCulture;
            csv.Configuration.RegisterClassMap<ClassificationMap>();
            var classificationsRecords = csv.GetRecords<Classification>().ToArray();
            context.Classifications.AddOrUpdate(c => c.Name, classificationsRecords);
            //Cars
            reader = new StreamReader(ResourcePaths.Cars);
            csv = new CsvReader(reader);
            csv.Configuration.Delimiter = ",";
            csv.Configuration.CultureInfo = CultureInfo.InvariantCulture;
            CarMap.Classifications = classificationsRecords.ToList();
            csv.Configuration.RegisterClassMap<CarMap>();
            var carsRecords = csv.GetRecords<Car>().ToArray();
            context.Cars.AddOrUpdate(c => c.LicensePlate, carsRecords);
        }
    }
}