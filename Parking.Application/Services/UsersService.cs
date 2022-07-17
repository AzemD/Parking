using Parking.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Services
{
    public class UsersService : IUsersService
    {
        public Task<IEnumerable<UsersViewModel>> CreateUser(UsersViewModel usersViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsersViewModel>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsersViewModel>> GetUsersById(int usersId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsersViewModel>> UpdateUser(UsersViewModel usersViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
