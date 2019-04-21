using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
   public class RoleConfiguration : EntityTypeConfiguration<Role>
    {

        public RoleConfiguration()
        {
            HasKey(r => r.Id);

            HasIndex(r => r.Name)
                .IsUnique(true);

            Property(r => r.Name)
                .HasMaxLength(16)
                .IsRequired();

            Property(r => r.Description)
                .HasMaxLength(2048)
                .IsRequired();

        }


    }
}
