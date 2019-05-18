using System;
using System.Collections.Generic;
using System.Linq;
using CsvHelper.Configuration;

namespace CarRentalApp.Core.domain.SeedData
{
    public static class ResourcePaths
    {
        public static readonly string Clients = $"{Prefix}clients.csv";
        public static readonly string Classifications = $"{Prefix}classifications.csv";
        public static readonly string Cars = $"{Prefix}cars.csv";

        private static string Prefix =>
            "C:\\Users\\kowama\\Source\\Repos\\kowama\\Car-Rental-App\\CarRentalApp\\Core\\domain\\SeedData\\";
    }

    public sealed class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            AutoMap();
            Map(c => c.Rents).Ignore();
            Map(c => c.Id).Ignore();
        }
    }

    public sealed class ClassificationMap : ClassMap<Classification>
    {
        public ClassificationMap()
        {
            AutoMap();
            Map(c => c.Cars).Ignore();
            Map(c => c.Id).Ignore();
        }
    }

    public sealed class CarMap : ClassMap<Car>
    {
        public CarMap()
        {
            if (Classifications == null || !Classifications.Any())
                throw new Exception(typeof(CarMap).FullName
                                    + " Classifications prop Need to be initialized before use");

            Map(c => c.Name).Name(nameof(Car.Name));
            Map(c => c.LicensePlate).Name(nameof(Car.LicensePlate));
            Map(c => c.Classification).Name(nameof(Car.LicensePlate));
            Map(c => c.PricePerDay).Name(nameof(Car.PricePerDay));
            Map(c => c.PurchaseDate).Name(nameof(Car.PurchaseDate));
            Map(c => c.NextDrainDate).Name(nameof(Car.NextDrainDate));
            Map(c => c.Description).Name(nameof(Car.Description));
            Map(c => c.Rents).Ignore();
            Map(c => c.Id).Ignore();
            Map(c => c.CarImage).Ignore();
            Map(c => c.Classification).ConvertUsing(row => ReadNested(row.GetField(nameof(Car.Classification))));
        }

        public static List<Classification> Classifications { get; set; }

        private static Classification ReadNested(string classificationName)
        {
            return Classifications.SingleOrDefault(c => c.Name == classificationName);
        }
    }
}