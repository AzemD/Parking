using Parking.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Repositories
{
    public class ParkingLocationsRepository : IParkingLocationsRepository
    {
        public Task<IEnumerable<ParkingLocations>> CreateParkingLocation(ParkingLocations parkingLocations)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteParkingLocation()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocations>> GetParkingLocations()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocations>> GetParkingLocationsById(int parkingLocationsId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingLocations>> UpdateParkingLocation(ParkingLocations parkingLocations)
        {
            throw new NotImplementedException();
        }
    }
}
