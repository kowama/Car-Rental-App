using System.Collections.Generic;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Repositories;

namespace CarRentalApp.Persistence.Repositories
{
    public class RentRepository : Repository<Rent, string>, IRentRepository
    {
        public CarRentalAppContext CarRentalAppContext => Context as CarRentalAppContext;


        public RentRepository(CarRentalAppContext context) : base(context)
        {

        }

        public IEnumerable<Rent> GetPendingRents()
        {
           return Find(r => r.State == RentState.Pending);
        }
    }

   
}