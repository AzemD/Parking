using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infrastructure.Data.Interfaces
{
    public interface IParkingLocationsRepository
    {
        Task<IEnumerable<ParkingLocations>> GetParkingLocations();
        Task<IEnumerable<ParkingLocations>> CreateParkingLocation(ParkingLocations parkingLocations);//Pa viewModel
        Task<IEnumerable<ParkingLocations>> UpdateParkingLocation(ParkingLocations parkingLocations);
        Task<IEnumerable<ParkingLocations>> GetParkingLocationsById(int parkingLocationsId);
        Task<bool> DeleteParkingLocation();
        Task<bool> DeleteParkingLocation();
    }
}
