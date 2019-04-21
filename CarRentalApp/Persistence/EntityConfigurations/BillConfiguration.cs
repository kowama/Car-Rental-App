using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;


namespace CarRentalApp.Persistence.EntityConfigurations
{
    public class BillConfiguration  : EntityTypeConfiguration<Bill>
   {
       public BillConfiguration()
       {
           HasKey(b => b.BillNumber);

           Property(b => b.Amount)
               .IsRequired();

           Property(b => b.Details)
               .HasMaxLength(2048);

           Property(b => b.BillNumber)
               .HasMaxLength(8)
               .IsFixedLength()
               .IsRequired();
  
           HasRequired(b => b.Rent)
               .WithOptional(r => r.Bill);


       }

    }
}