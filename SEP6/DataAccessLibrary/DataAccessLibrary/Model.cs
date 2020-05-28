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
        private List<AirlineModel> airlines;

        public Model(ISqlDataAccess db)
        {
            _db = db;
            Console.WriteLine("Model Initialized.");
        }

        public async Task<List<FlightModel>> GetFlightsAsync()
        {
            Console.WriteLine("Requesting Flighs.");
            if (flights == null)
            {
                string sql = "SELECT month, count(month) FROM public.flights GROUP BY month ORDER BY month ASC;";
                
                var data =  await _db.LoadData<FlightModel, dynamic>(sql, new { });
                
                flights = data;
                Console.WriteLine(flights.Count);
            }
            return flights;
        }

        public async Task<List<AirlineModel>> GetAirlinesAsync()
        {
            Console.WriteLine("Requesting Airlines.");
            if (airlines == null)
            {
                string sql = "SELECT name, carrier FROM public.airlines LIMIT 10;";

                var data = await _db.LoadData<AirlineModel, dynamic>(sql, new { });

                airlines = data;

                Console.WriteLine(airlines.Count);
                return airlines;
            }
            else
                return airlines;
        }
    }
}
