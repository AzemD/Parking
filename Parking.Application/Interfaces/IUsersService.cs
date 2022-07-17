using System;
using Parking.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<UsersViewModel>> GetUsers();
        Task<IEnumerable<UsersViewModel>> CreateUser(UsersViewModel usersViewModel);
        Task<IEnumerable<UsersViewModel>> UpdateUser(UsersViewModel usersViewModel);
        Task<IEnumerable<UsersViewModel>> GetUsersById(int usersId);
        Task<bool> DeleteUser();
    }
}
