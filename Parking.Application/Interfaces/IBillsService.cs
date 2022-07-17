using Parking.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Interfaces
{
    public interface IBillsService
    {
        Task<IEnumerable<BillsViewModel>> GetBills();
        Task<IEnumerable<BillsViewModel>> CreateBill(BillsViewModel billsViewModel);
        Task<IEnumerable<BillsViewModel>> UpdateBill(BillsViewModel billsViewModel);
        Task<IEnumerable<BillsViewModel>> GetBillsById(int billsId);
        Task<bool> DeleteBill();

    }
}
