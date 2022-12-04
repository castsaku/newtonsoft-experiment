using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi12
{
    public class Item
    {
        public string status { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string name { get; set; }
        public string text { get; set; }
        public string card_type { get; set; }
        public string type { get; set; }
        public string family { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string property { get; set; }
    }
}
