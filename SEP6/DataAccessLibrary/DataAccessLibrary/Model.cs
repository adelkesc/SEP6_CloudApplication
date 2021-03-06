﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Model : IModel
    {
        private readonly ISqlDataAccess _db;
        private List<FlightModel> flightsTotal;
        private List<FlightModel> flightsPerMonth;
        private List<FlightModel> flightsPerMonthOrigin;
        private List<FlightModel> flightsPerTopDest;
        private List<FlightModel> flightsWeatherPerOrigin;
        private List<FlightModel> flightsTempOrigins;
        private List<FlightModel> flightsMeanTempOrigins;
        private List<FlightModel> flightsDelay;
        private List<FlightModel> flightsManuMoreThan200;
        private List<FlightModel> flightsPerBigManu;
        private List<FlightModel> flightsAirbusPerManu;

        public Model(ISqlDataAccess db)
        {
            _db = db;
            Console.WriteLine("Model Initialized.");
        }

        //Returns names of months in a string array
        public string[] MonthNames()
        {
            string[] months;
            months = new[] { "January", "February", "March", "April", "May", "June", "July", "August"
        , "September", "October", "November", "December"};
            return months;
        }
        public string[] TopDestinationsNames()
        {
            string[] destinations = new string[] {"ATL", "BOS", "CLT", "DFW", "IAH",
                                                  "LAX", "MCO","MIA","ORD","SFO"};
            
            return destinations;
        }

        public string[] ManuNames()
        {
            string[] names = new string[] { "BOEING", "AIRBUS INDUSTRIE", "AIRBUS", "EMBRAER", "BOMBARDIER INC" };
            return names;
        }

        public double[] Percentage(List<FlightModel> flights, string origin)
        {
            double[] count = new double[12];
            int index = 0;
            double value;

            foreach(var flight in flights)
            {
                if(flight.Origin == origin)
                {
                    value = (flight.Count / flightsTotal[index].Count) * 100;
                    count[index] = Math.Round(value, 2);
                    index++;
                }
                
            }
            return count;
        }

        public async Task<List<FlightModel>> TotalFlightsMonthAsync()
        {
            Console.WriteLine("TotalFlightsMonth()");
            if (flightsTotal == null)
            {
                string sql = "SELECT COUNT(flight), month FROM public.flights " +
                             "GROUP BY month ORDER BY month ASC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsTotal = data;
            }
            return flightsTotal;
        }

        public async Task<List<FlightModel>> NoFlightsPerMonthAsync()
        {
            Console.WriteLine("Requesting NoFlightsPerMonthAsync()");
            if (flightsPerMonth == null)
            {
                string sql = "SELECT month, count(month), origin FROM public.flights GROUP BY  origin, month ORDER BY month ASC;";
                
                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsPerMonth = data;
            }
            Console.WriteLine(flightsPerMonth.Count);
            return flightsPerMonth;
        }
        public async Task<List<FlightModel>> NoFlightsPerMonthPerOriginAsync()
        {
            Console.WriteLine("Requesting NoFlightsPerMonthOriginAsync()");
            if (flightsPerMonthOrigin == null)
            {
                string sql = "SELECT COUNT(flight), month, origin FROM public.flights " +
                             "GROUP BY month, origin ORDER BY month ASC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsPerMonthOrigin = data;
                Console.WriteLine(flightsPerMonthOrigin.Count);
            }
            return flightsPerMonthOrigin;
        }
        public async Task<List<FlightModel>> FlightsPerTopDestAsync()
        {
            Console.WriteLine("Requesting FlightsPerTopDestAsync()");
            if (flightsPerTopDest == null)
            {
                string sql = "SELECT origin, dest, COUNT(flight), AVG(air_time) AS Air_time FROM flights " +
                    "WHERE dest = 'ORD' OR dest = 'LAX' OR dest = 'MIA' OR dest = 'ATL' OR dest = " +
                    "'SFO' OR dest = 'BOS' OR dest = 'CLT' OR dest = 'DFW' OR dest = 'MCO' OR dest = " +
                    "'IAH' GROUP BY dest, origin ORDER BY dest;";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsPerTopDest = data;
            }
            return flightsPerTopDest;
        }
        public async Task<List<FlightModel>> NoOfWeatherObservationsPerOriginAsync()
        {
            Console.WriteLine("Requesting NoOfWeatherObservationsPerOriginAsync()");
            if (flightsWeatherPerOrigin == null)
            {
                string sql = "SELECT origin, COUNT(temp) FROM public.weather " +
                             "GROUP BY origin ORDER BY COUNT(temp) ASC;";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsWeatherPerOrigin = data;
            }
            return flightsWeatherPerOrigin;
        }
        //Can be used for requirement 6 as well.
        public async Task<List<FlightModel>> TempPerOriginAsync()
        {
            Console.WriteLine("Requesting TempPerOriginAsync()");
            if (flightsTempOrigins == null)
            {
                string sql = "SELECT origin, time_hour, (temp-32)*5/9 AS Celsius FROM weather " +
                             "GROUP BY time_hour, origin, temp ORDER BY time_hour ASC;";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsTempOrigins = data;
                Console.WriteLine(flightsTempOrigins.Count);
            }
            return flightsTempOrigins;
        }
        //Can be used for requirement 7 as well.
        public async Task<List<FlightModel>> MeanTempPerOriginAsync()
        {
            Console.WriteLine("Requesting MeanTempPerOriginAsync()");
            if (flightsMeanTempOrigins == null)
            {
                string sql = "SELECT origin, month, day, (AVG(temp)-32)*5/9 AS Celsius FROM weather " +
                             "GROUP BY origin, month, day ORDER BY origin, month, day; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsMeanTempOrigins = data;
                Console.WriteLine(flightsMeanTempOrigins.Count);
            }
            return flightsMeanTempOrigins;
        }
        public async Task<List<FlightModel>> MeanDelayPerOriginAsync()
        {
            Console.WriteLine("Requesting MeanDelayPerOriginAsync()");
            if (flightsDelay == null)
            {
                string sql = "SELECT origin, AVG(arr_delay) AS avg_arr, AVG(dep_delay) as avg_dep " +
                             "FROM public.flights GROUP BY origin; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsDelay = data;
                Console.WriteLine(flightsDelay.Count);

            }
            return flightsDelay;
        }
        public async Task<List<FlightModel>> ManufacturersWithShitLoadOfPlanesAsync()
        {
            Console.WriteLine("Requesting ManufacturersWithShitLoadOfPlanesAsync()");
            if (flightsManuMoreThan200 == null)
            {
                string sql = "SELECT manufacturer, COUNT(tailnum) FROM public.planes GROUP BY manufacturer " +
                             "HAVING COUNT(tailnum) > 200 ORDER BY COUNT(tailnum) DESC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsManuMoreThan200 = data;
                Console.WriteLine(flightsManuMoreThan200.Count);

            }
            return flightsManuMoreThan200;
        }
        //INCONSISTENT
        public async Task<List<FlightModel>> FlightsPerBigManufacturerAsync()
        {
            Console.WriteLine("Requesting FlightsPerBigManufacturerAsync()");
            if (flightsPerBigManu == null)
            {
                string sql = "SELECT planes.manufacturer, COUNT(flight) FROM planes, flights " +
                    "WHERE planes.tailnum = flights.tailnum AND(manufacturer = 'BOEING' OR manufacturer = 'AIRBUS INDUSTRIE'" +
                    "OR manufacturer = 'BOMBARDIER INC' OR manufacturer = 'AIRBUS' OR manufacturer = 'EMBRAER') " +
                    "GROUP BY manufacturer ORDER BY COUNT(flight) DESC; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsPerBigManu = data;
                Console.WriteLine(flightsPerBigManu.Count);
            }
            return flightsPerBigManu;
        }
        public async Task<List<FlightModel>> NoOfAirbusesPerModelAsync()
        {
            Console.WriteLine("Requesting NoOfAirbusesPerModelAsync()");
            if (flightsAirbusPerManu == null)
            {
                string sql = "SELECT manufacturer, COUNT(tailnum) FROM public.planes WHERE manufacturer = " +
                             "'AIRBUS INDUSTRIE' OR manufacturer = 'AIRBUS' GROUP BY manufacturer; ";

                var data = await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flightsAirbusPerManu = data;
                Console.WriteLine(flightsAirbusPerManu.Count);

            }
            return flightsAirbusPerManu;
        }

     
    }
}
