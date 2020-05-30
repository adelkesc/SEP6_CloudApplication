using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Model : IModel
    {
        private readonly ISqlDataAccess _db;
        private List<FlightModel> flights;

        public Model(ISqlDataAccess db)
        {
            _db = db;
            Console.WriteLine("Model Initialized.");
        }

        public async Task<List<FlightModel>> NoFlightsPerMonthAsync()
        {
            Console.WriteLine("Requesting NoFlightsPerMonthAsync()");
            if (flights == null)
            {
                string sql = "SELECT month, count(month) FROM public.flights GROUP BY month ORDER BY month ASC;";
                
                var data =  await _db.LoadData<FlightModel, dynamic>(sql, new { });
                
                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> NoFlightsPerMonthPerOriginAsync()
        {
            Console.WriteLine("Requesting NoFlightsPerMonthOriginAsync()");
            if (flights == null)
            {
                string sql = "SELECT COUNT(flight), month, origin FROM public.flights " +
                             "GROUP BY month, origin ORDER BY month ASC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> FlightsPerTopDestAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT COUNT(flight), dest FROM public.flights " +
                             "GROUP BY dest ORDER BY COUNT(flight) DESC LIMIT 10; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> NoOfWeatherObservationsPerOriginAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT origin, COUNT(temp) FROM public.weather " +
                             "GROUP BY origin ORDER BY COUNT(temp) ASC;";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> TempAtJFKInCelsiusAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT origin, hour, (temp-32)*5/9 AS Celsius FROM public.weather WHERE origin = 'JFK';";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> DailyMeanTempAtJFKAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT origin, year, month, day, (AVG(temp)-32)*5/9 AS Celsius FROM public.weather"+
                             " WHERE origin = 'JFK' GROUP BY origin, year, month, day; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> DailyMeanTempPerOriginAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT origin, year, month, day, (AVG(temp) - 32)*5 / 9 AS Celsius " +
                             "FROM public.weather GROUP BY origin, year, month, day ORDER BY origin;";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> MeanDelayPerOriginAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT origin, AVG(arr_delay) AS avg_delay, AVG(dep_delay) as avg_dep " +
                             "FROM public.flights GROUP BY origin; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> ManufacturersWithShitLoadOfPlanesAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT manufacturer, COUNT(tailnum) FROM public.planes GROUP BY manufacturer " +
                             "HAVING COUNT(tailnum) > 200 ORDER BY COUNT(tailnum) DESC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> AvgFlightsPerBigManufacturerAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT planes.manufacturer, COUNT(flight) FROM public.planes, flights WHERE planes.tailnum = flights.tailnum " +
                             "GROUP BY manufacturer HAVING COUNT(planes.tailnum) > 200 ORDER BY COUNT(flight) DESC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<FlightModel>> NoOfAirbusesPerModelAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flights == null)
            {
                string sql = "SELECT manufacturer, COUNT(tailnum) FROM public.planes WHERE manufacturer = " +
                             "'AIRBUS INDUSTRIE' OR manufacturer = 'AIRBUS' GROUP BY manufacturer; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }
    }
}
