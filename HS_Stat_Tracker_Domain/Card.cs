using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Stat_Tracker_Domain
{
    public class Card
    {
        public int ID { get; set; }
        public int dbfId { get; set; }
        public string type { get; set; }
        public string flavor { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string rarity { get; set; }
        public string set { get; set; }
        public string artist { get; set; }
        public string cardClass { get; set; }
        public Boolean collectible { get; set; }
        public int cost { get; set; }
        public string text { get; set; }
    }
}
