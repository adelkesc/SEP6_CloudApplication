using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class FlightData : IFlightData
    {
        private readonly ISqlDataAccess _db;
        private List<FlightModel> flights;

        public FlightData(ISqlDataAccess db)
        {
            _db = db;
            Console.WriteLine("Initialized");
        }

        public async Task<List<FlightModel>> GetFlightsAsync()
        {
            if (flights == null)
            {
                Console.WriteLine("requesting");

                string sql = "SELECT year, month, day, dep_time, dep_delay, arr_time, arr_delay, carrier, " +
                             "tailnum, flight, origin, dest, air_time, distance, hour, minute FROM public.flights LIMIT 1000;";
                
                var data =  await _db.LoadData<FlightModel, dynamic>(sql, new { });

                flights = data;

                Console.WriteLine(flights.Count);

                return flights;
            }
            else
                return flights;
        }
    }
}
