using System;
using Parking.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Interfaces
{
    public interface IRolesService
    {
        Task<IEnumerable<RolesViewModel>> GetRoles();
        Task<IEnumerable<RolesViewModel>> CreateBill(RolesViewModel rolesViewModel);
        Task<IEnumerable<RolesViewModel>> UpdateBill(RolesViewModel rolesViewModel);
        Task<IEnumerable<RolesViewModel>> GetRolesById(int rolesId);
        Task<bool> DeleteBill();
    }
}
