using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class FlightModel
    {
        public List<double> CountOfFlightsPerMonth(List<FlightModel> flights)
        {
            List<double> count;
            count = new List<double>();

            foreach (var flight in flights)
            {
                count.Add((double)flight.Count);
            }
            return count;
        }
        public int Month { get; set; }

        public int Count { get; set; }

        public string Day { get; set; }

        public string Avg_dep { get; set; }
        
        public string Avg_arr { get; set; }

        public string Carrier { get; set; }

        public string Tailnum { get; set; }

        public string Flight { get; set; }

        public string Origin { get; set; }

        public string Dest { get; set; }

        public string Air_time { get; set; }

        public string Distance { get; set; }

        public double Temp { get; set; }

        public double Avg { get; set; }

        public string Manufacturer { get; set; }

        public DateTime Time_hour { get; set; }
    }
}
