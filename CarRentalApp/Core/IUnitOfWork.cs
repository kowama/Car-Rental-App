using System;
using CarRentalApp.Core.Repositories;

namespace CarRentalApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
//        IUserRepository Users { get; }
        IRentRepository Rents { get; }

        int Complete();
    }
}