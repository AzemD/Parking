using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Interfaces
{
    public interface IRolesRepository
    {
        Task<IEnumerable<Roles>> GetRoles();
        Task<IEnumerable<Roles>> CreateRole(Roles roles);//Pa viewModel
        Task<IEnumerable<Roles>> UpdateBill(Roles roles);
        Task<IEnumerable<Roles>> GetRolesById(int rolesId);
        Task<bool> DeleteRole();
        Task<bool> DeleteRole();
    }
}
