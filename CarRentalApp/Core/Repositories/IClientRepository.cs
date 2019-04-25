using System;
using CarRentalApp.Core.domain;

namespace CarRentalApp.Core.Repositories
{
    public interface IClientRepository : IRepository<Client, Guid>
    {
        
    }
}