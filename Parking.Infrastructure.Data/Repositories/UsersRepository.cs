using Parking.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public Task<IEnumerable<Users>> CreateUser(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetUsersById(int usersId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> UpdateBill(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
