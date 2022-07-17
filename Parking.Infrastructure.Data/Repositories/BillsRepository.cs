using Parking.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Repositories
{
    public class BillsRepository : IBillsRepository
    {
        public Task<IEnumerable<Bills>> CreateBill(Bills bills)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBill()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bills>> GetBills()
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
