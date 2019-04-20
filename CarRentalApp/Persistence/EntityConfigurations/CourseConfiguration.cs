using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
    public class RentConfiguration : EntityTypeConfiguration<Rent>
    {
        public RentConfiguration()
        {
            HasKey(r => new {r.ClientId, r.CarId, r.UserId, r.RentId});

            Property(r => r.DateStart)
                .IsRequired();

            Property(r => r.RentId)
                .HasMaxLength(8)
                .IsFixedLength()
                .IsRequired();

            Property(r => r.State)
                .IsRequired();

           

        }
    }
}