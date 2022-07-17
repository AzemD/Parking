using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Application.Interfaces;
using Parking.Application.ViewModel;

namespace Parking.Application.Services
{
    public class RolesService : IRolesService
    {
        public Task<IEnumerable<RolesViewModel>> CreateBill(RolesViewModel rolesViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBill()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RolesViewModel>> GetRoles()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RolesViewModel>> GetRolesById(int rolesId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RolesViewModel>> UpdateBill(RolesViewModel rolesViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
