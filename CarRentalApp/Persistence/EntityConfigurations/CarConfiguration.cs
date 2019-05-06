using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            HasKey(c => c.Id);

            HasIndex(c => c.LicensePlate)
                .IsUnique();

            Property(c => c.Description)
                .HasMaxLength(2048);

            Property(c => c.LicensePlate)
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.CarImage)
                .IsOptional();


            Property(c => c.PricePerDay)
                .IsRequired();

            HasRequired(c => c.Classification)
                .WithMany(cl => cl.Cars)
                .Map(m => m.MapKey("ClassificationId"));
        }
    }
}