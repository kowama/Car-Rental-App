using CarRentalApp.Core;
using CarRentalApp.Core.Repositories;
using CarRentalApp.Persistence.Repositories;

namespace CarRentalApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarRentalAppContext _context;

        public UnitOfWork(CarRentalAppContext context)
        {
            _context = context;
            Rents = new RentRepository(_context);
        }

        public IRentRepository Rents { get; private set; }

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