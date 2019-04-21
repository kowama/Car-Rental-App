
using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
  public  class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.LicensePlate)
                .HasMaxLength(15)
                .IsRequired();

            Property(c => c.Description)
                .HasMaxLength(2048);

            Property(c => c.PricePerDay)
                .IsRequired();

        }
    }
}
