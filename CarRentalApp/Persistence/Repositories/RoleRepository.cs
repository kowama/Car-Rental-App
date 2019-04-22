using System.Linq;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Repositories;

namespace CarRentalApp.Persistence.Repositories
{
    public class RoleRepository : Repository<Role, int>, IRoleRepository
    {
        public RoleRepository(CarRentalAppContext context) : base(context)
        {
        }

        public CarRentalAppContext CarRentalAppContext => Context as CarRentalAppContext;

        public Role GetRoleByName(string roleName)
        {
            return Find(role => role.Name == roleName).First();
        }
    }
}