using Parking.Application.Interfaces;
using Parking.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Services
{
    public class BillsService : IBillsService
    {
        public Task<IEnumerable<BillsViewModel>> CreateBill(BillsViewModel billsViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBill()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillsViewModel>> GetBill()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillsViewModel>> GetBills()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillsViewModel>> GetBillsById(int billsId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillsViewModel>> UpdateBill(BillsViewModel billsViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
