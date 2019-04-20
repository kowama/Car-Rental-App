using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
    public class RentConfiguration : EntityTypeConfiguration<Rent>
    {
        public RentConfiguration()
        {
            HasKey(r =>  r.RentId);


            Property(r => r.DateStart)
                .IsRequired();

            Property(r => r.DateEnd)
                .IsOptional();

            Property(r => r.RentId)
                .HasMaxLength(8)
                .IsFixedLength()
                .IsRequired();

            Property(r => r.State)
                .IsRequired();


            HasOptional(r => r.Bill)
                .WithRequired(b => b.Rent)
                .Map(m => m.MapKey("RentID"))
                .WillCascadeOnDelete(true);
                

            HasRequired(r => r.Car)
                .WithMany(c => c.Rents)
                .Map(m =>
                {
                    m.MapKey("CarId");
                });


            HasRequired(r => r.Client)
                .WithMany(c => c.Rents)
             .Map(m => m.MapKey("ClientId"));


            HasRequired(r => r.ManageByUser)
                .WithMany(u => u.Rents)
                .Map(m => m.MapKey("UserId"));



        }
    }
}