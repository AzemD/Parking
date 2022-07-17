using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetUsers();
        Task<IEnumerable<Users>> CreateUser(Users users);//Pa viewModel
        Task<IEnumerable<Users>> UpdateBill(Users users);
        Task<IEnumerable<Users>> GetUsersById(int usersId);
        Task<bool> DeleteUser();
        Task<bool> DeleteUsers();
    }
}
