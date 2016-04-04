using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Gudvis
{
    class Event
    {
        public string eventID { get; set; }

        public string name { get; set; }

        public string location { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }

        public string phone { get; set; }

        public string mail { get; set; }

        public string description { get; set; }

        public DateTime startDateTime { get; set; }

        public DateTime endDateTime { get; set; }
    }
}
