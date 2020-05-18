using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    interface IFlightData
    {
        Task<List<FlightModel>> GetFlights();
    }
}