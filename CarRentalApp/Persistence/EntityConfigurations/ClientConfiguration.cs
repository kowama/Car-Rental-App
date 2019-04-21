
using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
   public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Address)
                .HasMaxLength(256);

            Property(c => c.Email)
                .HasMaxLength(64);

            Property(c => c.FirstName)
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.LastName)
                .HasMaxLength(32);

            Property(c => c.Phone)
                .HasMaxLength(16);
        }
    }
}
