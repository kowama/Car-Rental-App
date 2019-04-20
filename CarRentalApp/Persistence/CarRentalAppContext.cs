using CarRentalApp.Persistence.EntityConfigurations;
using System.Data.Entity;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Persistence
{
    public class CarRentalAppContext : DbContext
    {
        public CarRentalAppContext()
            : base("name=CarRentalAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RentConfiguration());
        }
    }
}
