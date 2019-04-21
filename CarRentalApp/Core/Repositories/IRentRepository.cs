using System.Collections.Generic;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Core.Repositories
{
    public interface IRentRepository : IRepository<Rent, string>
    {
        IEnumerable<Rent> GetPendingRents();

    }
}