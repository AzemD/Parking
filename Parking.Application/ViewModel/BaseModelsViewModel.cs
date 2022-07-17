using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.ViewModel
{
    public class BaseModelsViewModel
    {
        public bool? IsDeleted { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpadateDate { get; set; }
        public DateTime? LastUpdateAt { get; set; }
    }
}
