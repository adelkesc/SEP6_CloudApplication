using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    class FlightData : IFlightData
    {
        private readonly ISqlDataAccess _db;

        public FlightData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<FlightModel>> GetFlights()
        {
            string sql = "SELECT year, month, day, dep_time, dep_delay, arr_time, arr_delay, carrier, " +
                         "tailnum, flight, origin, dest, air_time, distance, hour, minute FROM public.flights;";

            return _db.LoadData<FlightModel, dynamic>(sql, new { });
        }
    }
}
