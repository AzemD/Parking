using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.ViewModel
{
    public class BillsViewModel : BaseModelsViewModel
    {
        public int BillID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal? Price { get; set; }
        public string Targat { get; set; }
        public int ParkingLocationID { get; set; }
        public int UserID { get; set; }
    }
}
