using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IModel
    {
        Task<List<FlightModel>> GetFlightsAsync();
        Task<List<AirlineModel>> GetAirlinesAsync();
    }
}