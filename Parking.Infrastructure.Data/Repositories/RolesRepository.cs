using Parking.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        public Task<IEnumerable<Roles>> CreateRole(Roles roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRole()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Roles>> GetRoles()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Roles>> GetRolesById(int rolesId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Roles>> UpdateBill(Roles roles)
        {
            throw new NotImplementedException();
        }
    }
}
