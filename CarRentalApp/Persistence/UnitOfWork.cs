using CarRentalApp.Core;
using CarRentalApp.Core.Repositories;
using CarRentalApp.Persistence.Repositories;

namespace CarRentalApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarRentalAppContext _context;

        public UnitOfWork()
        {
            _context = new CarRentalAppContext();

            Bills = new BillRepository(_context);
            Cars = new CarRepository(_context);
            Clients = new ClientRepository(_context);
            Classifications = new ClassificationRepository(_context);
            Rents = new RentRepository(_context);
            Roles = new RoleRepository(_context);
            Users = new UserRepository(_context);
        }
        
        public IBillRepository Bills { get; private set; }

        public ICarRepository Cars { get; private set; }

        public IClassificationRepository Classifications { get; private set; }

        public IClientRepository Clients { get; private set; }

        public IRentRepository Rents { get; }

        public IRoleRepository Roles { get; private set; }

        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}