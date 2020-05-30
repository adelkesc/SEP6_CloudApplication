using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class FlightModel
    {

        public string Year { get; set; }

        public int Month { get; set; }

        public int Count { get; set; }

        public string Day { get; set; }

        public string Dep_time { get; set; }

        public string Dep_delay { get; set; }
        
        public string Arr_time { get; set; }

        public string Arr_delay { get; set; }

        public string Carrier { get; set; }

        public string Tailnum { get; set; }

        public string Flight { get; set; }

        public string Origin { get; set; }

        public string Dest { get; set; }

        public string Air_time { get; set; }

        public string Distance { get; set; }

        public string Hour { get; set; }

        public string Minute { get; set; }

        public double Celsius { get; set; }
    }
}
