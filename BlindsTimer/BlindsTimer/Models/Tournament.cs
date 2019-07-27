using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace BlindsTimer.Models
{
    public class Tournament
    {
        public int NumberOfLevels { get; set; }
        public int LevelMinutes { get; set; }     
        public int BreakFrequency { get; set; }
        public int BreakLength { get; set; }
        public Dictionary<int, Level>BlindStructure { get; set; }
        
    }
}
