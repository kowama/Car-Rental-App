using CarRentalApp.Core.domain;

namespace CarRentalApp.Core.Repositories
{
    public interface IRoleRepository : IRepository<Role, int>
    {
        Role GetRoleByName(string RoleName);
    }
}