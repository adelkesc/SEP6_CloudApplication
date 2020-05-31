using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class FlightModel
    {
        public double[] TotalFlights(List<FlightModel> flights, string origin)
        {
            double[] count = new double[flights.Count];
            int index = 0;
            foreach (var flight in flights)
            {
                if(flight.Origin == origin)
                {
                    count[index] = (double)flight.Count;
                    index++;
                }
            }
            return count;
        }

        public double[] Temperatures(List<FlightModel> flights, string origin)
        {
            int size = 0;
            foreach(var flight in flights)
            {
                if (flight.Origin == origin)
                {
                    size++;
                }
            }
            double[] count = new double[size];
            int index = 0;
            foreach (var flight in flights)
            {
                if (flight.Origin == origin)
                {
                    count[index] = Math.Round((double)flight.Celsius,2);
                    index++;
                }
            }
            return count;
        }

        public string[] GetDateFormat(List<FlightModel> flights)
        {
            int size = 0;
            foreach (var flight in flights)
            {
                if (flight.Origin == "JFK")
                {
                    size++;
                }
            }
            string[] calendar = new string[size];
            int index = 0;
            foreach (var flight in flights)
            {
                if(flight.Origin == "JFK")
                {
                    calendar[index] = flight.Time_hour.ToString();
                    index++;
                }
                
            }
            return calendar;
        }

        public string[] GetMeanDateFormat(List<FlightModel> flights)
        {
            int size = 0;
            foreach (var flight in flights)
            {
                if (flight.Origin == "JFK")
                {
                    size++;
                }
            }
            string[] calendar = new string[size];
            int index = 0;
            foreach (var flight in flights)
            {
                if (flight.Origin == "JFK")
                {
                    calendar[index] = flight.Month.ToString() + " / "+ flight.Day.ToString();
                    index++;
                }

            }
            return calendar;
        }

        public int Month { get; set; }
        public string MonthName { get; set; }

        public double Count { get; set; }

        public string Day { get; set; }

        public double Avg_dep { get; set; }
        
        public double Avg_arr { get; set; }

        public string Carrier { get; set; }

        public string Tailnum { get; set; }

        public string Flight { get; set; }

        public string Origin { get; set; }

        public string Dest { get; set; }

        public double Air_time { get; set; }

        public string Distance { get; set; }

        public double Temp { get; set; }

        public double Avg { get; set; }

        public string Manufacturer { get; set; }

        public DateTime Time_hour { get; set; }

        public double Celsius { get; set; }
    }
}
