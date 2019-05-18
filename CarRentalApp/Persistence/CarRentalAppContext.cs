using System.Data.Entity;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence.EntityConfigurations;

namespace CarRentalApp.Persistence
{
    public class CarRentalAppContext : DbContext
    {
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public CarRentalAppContext()
            : base("name=CarRentalAppContext")
        {
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer(new CarRentalDbInitializer());
            Database.Initialize(true);

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BillConfiguration());
            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new ClassificationConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new RentConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());


        }
     
    }
}
