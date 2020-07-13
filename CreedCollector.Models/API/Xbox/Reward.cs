using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Models.API.Xbox
{
    public class Reward
    {
        public object name { get; set; }
        public object description { get; set; }
        public int value { get; set; }
        public string type { get; set; }
        public object mediaAsset { get; set; }
        public string valueType { get; set; }
    }
}
