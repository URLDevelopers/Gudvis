using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Gudvis
{
    public class Level
    {
        public int levelNumber { get; set; }
        
        public string name { get; set; }
        
        public string icon { get; set; }
        
        public int min_score { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
