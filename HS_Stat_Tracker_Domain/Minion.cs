using HS_Stat_Tracker_Domain.Domain_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Stat_Tracker_Domain
{
    public class Minion: Card
    {

        public int attack { get; set; }
        public int health { get; set; }
        public string[] mechanics { get; set; }
        public string race { get; set; }
        //       public string type;

        //        string type { get; set; }
    }
}
