using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    class AirportModel
    {
        public string FAA { get; set; }

        public string Name { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }

        public string Alt { get; set; }

        public string Tz { get; set; }

        public string Dst { get; set; }

        public string Tzone { get; set; }
    }
}
