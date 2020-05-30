using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class FlightModel
    {
        public int[] CountOfFlightsPerMonth(List<FlightModel> flights)
        {
            int[] count = new int[flights.Count];
            int index = 0;
            foreach (var flight in flights)
            {
                count[index] = (int)flight.Count;
                index++;
            }
            Console.WriteLine(count);
            return count;
        }
        public int Month { get; set; }
        public string MonthName { get; set; }

        public double Count { get; set; }

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
