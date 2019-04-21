using System;
using CarRentalApp.Core.Repositories;

namespace CarRentalApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBillRepository Bills { get; }
        ICarRepository Cars { get; }
        IClassificationRepository Classifications { get; }
        IClientRepository Clients { get; }
        IRentRepository Rents { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}