using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    class WeatherModel
    {
        public string Origin { get; set; }

        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public string Hour { get; set; }

        public string Temp { get; set; }

        public string Dewp { get; set; }

        public string Humid { get; set; }

        public string Wind_dir { get; set; }

        public string Wind_speed { get; set; }

        public string Wind_gust { get; set; }

        public string Precip { get; set; }

        public string Pressure { get; set; }

        public string Visib { get; set; }

        public string Time_hour { get; set; }
    }
}
