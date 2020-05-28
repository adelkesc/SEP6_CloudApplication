using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IFlightData
    {
        Task<List<FlightModel>> GetFlightsAsync();
    }
}