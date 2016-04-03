using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudvis_final
{
    public class User
    {
        public string username { get; set; }
        
        public string fbID { get; set; }
        
        public string firstname { get; set; }
        
        public string lastname { get; set; }

        public string fullname { get { return firstname + " " + lastname; } }

        public string picture_link { get; set; }
        
        public string gender { get; set; }
        
        public string location { get; set; }
        
        public DateTime birthday { get; set; }

        public Int64 score { get; set; }
        
        public int levelNumber { get; set; }

        public Level Level { get; set; }
    }
}
