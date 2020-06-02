using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IModel
    {
        string[] MonthNames();
        string[] TopDestinationsNames();

        string[] ManuNames();

        double[] Percentage(List<FlightModel> flights, string origin);

        Task<List<FlightModel>> TotalFlightsMonthAsync();

        Task<List<FlightModel>> NoFlightsPerMonthAsync();

        Task<List<FlightModel>> NoFlightsPerMonthPerOriginAsync();

        Task<List<FlightModel>> FlightsPerTopDestAsync();

        Task<List<FlightModel>> NoOfWeatherObservationsPerOriginAsync();

        Task<List<FlightModel>> TempPerOriginAsync();

        Task<List<FlightModel>> MeanTempPerOriginAsync();

        Task<List<FlightModel>> MeanDelayPerOriginAsync();

        Task<List<FlightModel>> ManufacturersWithShitLoadOfPlanesAsync();

        Task<List<FlightModel>> FlightsPerBigManufacturerAsync();

        Task<List<FlightModel>> NoOfAirbusesPerModelAsync();
    }
}