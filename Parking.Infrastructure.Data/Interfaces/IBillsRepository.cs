using Parking.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Interfaces
{
    public interface IBillsRepository
    {
        Task<IEnumerable<Bill>> GetBills();
        Task<IEnumerable<Bill>> CreateBill(Bills bills);//Pa viewModel
        Task<IEnumerable<BillsViewModel>> UpdateBill(BillsViewModel billsViewModel);
        Task<IEnumerable<BillsViewModel>> GetBillsById(int billsId);
        Task<bool> DeleteBill();
        Task<bool> DeleteBill();
    }
}
