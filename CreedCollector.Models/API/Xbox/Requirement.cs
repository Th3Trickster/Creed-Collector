using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Models.API.Xbox
{
    public class Requirement
    {
        // For Xbox One
        public string id { get; set; }
        public object current { get; set; }
        public int target { get; set; }
        public string operationType { get; set; }
        public string valueType { get; set; }
        public string ruleParticipationType { get; set; }
    }
}
