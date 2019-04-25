
using System.Data.Entity.ModelConfiguration;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence.EntityConfigurations
{
   public class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.Id);

            HasIndex(u => u.Username)
                .IsUnique();

            HasIndex(u => u.Cin)
                .IsUnique();

            HasIndex(u => u.Email)
                .IsUnique();


            Property(u => u.Cin)
                .IsRequired()
                .HasMaxLength(32);

            Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(32);

            Property(u => u.Email)
                .HasMaxLength(64);

            Property(u => u.FirstName)
                .HasMaxLength(32)
                .IsRequired();

            Property(u => u.LastName)
                .HasMaxLength(32);

            Property(u => u.Password)
                .HasMaxLength(128)
                .IsRequired();

            Property(u => u.Phone)
                .HasMaxLength(16);

            HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m =>
                {
                    m.ToTable("UsersRoles");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");

                });
        }
    }
}
