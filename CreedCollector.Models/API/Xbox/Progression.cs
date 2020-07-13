using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Models.API.Xbox
{
    public class Progression
    {
        public List<Requirement> requirements { get; set; }
        public DateTime timeUnlocked { get; set; }
    }
}
