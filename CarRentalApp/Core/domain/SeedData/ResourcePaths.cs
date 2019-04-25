using CsvHelper.Configuration;

namespace CarRentalApp.Core.domain.SeedData
{
    public static class ResourcePaths
    {
        public static readonly string Clients =
            "D:\\Projects\\Car-Rental-App\\CarRentalApp\\Core\\domain\\SeedData\\clients.csv";

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
}
