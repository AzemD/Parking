using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Application.Interfaces;
using Parking.Application.ViewModel;

namespace Parking.Application.Services
{
    public class ParkingLocationsServices : IParkingLocationsService

    {
        public Task<IEnumerable<ParkingLocationsViewModel>> CreateBill(ParkingLocationsViewModel parkinglocationsViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteParkingLocation()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocationsViewModel>> GetParkingLocations()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocationsViewModel>> GetParkingLocationsById(int parkinglocationsId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocationsViewModel>> UpdateParkingLocation(ParkingLocationsViewModel parkinglocationsViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
