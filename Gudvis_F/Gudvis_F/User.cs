using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudvis_F
{
    public class User
    {
        public string fbID { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string picture_link { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public DateTime birthday { get; set; }
        public Int64 LEVELS_number { get; set; }
        public Int64 score { get; set; }
    }
}
