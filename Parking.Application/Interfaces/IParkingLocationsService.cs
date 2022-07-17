using System;
using Parking.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Application.Interfaces
{
    public interface IParkingLocationsService
    {
        Task<IEnumerable<ParkingLocationsViewModel>> GetParkingLocations();
        Task<IEnumerable<ParkingLocationsViewModel>> CreateBill(ParkingLocationsViewModel parkinglocationsViewModel);
        Task<IEnumerable<ParkingLocationsViewModel>> UpdateParkingLocation(ParkingLocationsViewModel parkinglocationsViewModel);
        Task<IEnumerable<ParkingLocationsViewModel>> GetParkingLocationsById(int parkinglocationsId);
        Task<bool> DeleteParkingLocation();
    }
}
