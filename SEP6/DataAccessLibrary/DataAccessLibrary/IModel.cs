using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IModel
    {
        Task<List<FlightModel>> NoFlightsPerMonthAsync();

        Task<List<FlightModel>> NoFlightsPerMonthPerOriginAsync();

        Task<List<FlightModel>> FlightsPerTopDestAsync();

        Task<List<FlightModel>> NoOfWeatherObservationsPerOriginAsync();

        Task<List<FlightModel>> TempAtJFKInCelsiusAsync();

        Task<List<FlightModel>> DailyMeanTempAtJFKAsync();

        Task<List<FlightModel>> DailyMeanTempPerOriginAsync();

        Task<List<FlightModel>> MeanDelayPerOriginAsync();

        Task<List<FlightModel>> ManufacturersWithShitLoadOfPlanesAsync();

        Task<List<FlightModel>> AvgFlightsPerBigManufacturerAsync();

        Task<List<FlightModel>> NoOfAirbusesPerModelAsync();
    }
}