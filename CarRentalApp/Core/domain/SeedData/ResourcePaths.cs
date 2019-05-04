using System;
using System.Collections.Generic;
using System.Linq;
using CsvHelper.Configuration;

namespace CarRentalApp.Core.domain.SeedData
{
    public static class ResourcePaths
    {
        private static readonly string _prefix = "D:\\Projects\\Car-Rental-App\\CarRentalApp\\Core\\domain\\SeedData\\";

        public static readonly string Clients = $"{_prefix}clients.csv";
        public static readonly string Classifications = $"{_prefix}classifications.csv";
        public static readonly string Cars = $"{_prefix}cars.csv";
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
        public static List<Classification> Classifications { get; set; }

        public CarMap()
        {
            if (Classifications == null || !Classifications.Any())
                throw new Exception(typeof(CarMap).FullName
                                    + " Classifications prop Need to be initialized before use");

            Map(c => c.Name).Name("Name");
            Map(c => c.LicensePlate).Name("LicensePlate");
            Map(c => c.Classification).Name("Classification");
            Map(c => c.PricePerDay).Name("PricePerDay");
            Map(c => c.PurchaseDate).Name("PurchaseDate");
            Map(c => c.NextDrainDate).Name("NextDrainDate");
            Map(c => c.Description).Name("Description");
            Map(c => c.Rents).Ignore();
            Map(c => c.Id).Ignore();
            Map(c => c.CarImage).Ignore();
            Map(c => c.Classification).ConvertUsing(row => ReadNested(row.GetField("Classification")));
        }

        private static Classification ReadNested(string classificationName)
        {
            return Classifications.SingleOrDefault(c => c.Name == classificationName);
        }
    }
}