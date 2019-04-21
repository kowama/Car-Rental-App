using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
   public class ClassificationConfiguration : EntityTypeConfiguration<Classification>
    {

        public ClassificationConfiguration()
        {
            HasKey(c => c.Id);

            HasIndex(c => c.Name)
                .IsUnique();

            Property(c => c.Name)
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.Description)
                .HasMaxLength(2048)
                .IsRequired();
        }
    }
}
