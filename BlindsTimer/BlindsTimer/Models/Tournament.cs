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
        public IDictionary<int, Level> BlindStructure { get; set; }
        
        public Dictionary<int, Level> DefaultStructure = new Dictionary<int, Level>()
        {
            {0, new Level{SmallBlind=25, BigBlind=50} },
            {1, new Level{SmallBlind=50, BigBlind=100} },
            {2, new Level{SmallBlind=75, BigBlind=150} },
            {3, new Level{SmallBlind=100, BigBlind=200} },
            {4, new Level{SmallBlind=150, BigBlind=300} },
            {5, new Level{SmallBlind=200, BigBlind=400} },
            {6, new Level{SmallBlind=250, BigBlind=500} },
            {7, new Level{SmallBlind=300, BigBlind=600} },
            {8, new Level{SmallBlind=400, BigBlind=800} },
            {9, new Level{SmallBlind=500, BigBlind=1000} },
            {10, new Level{SmallBlind=600, BigBlind=1200} },
            {11, new Level{SmallBlind=700, BigBlind=1400} },
            {12, new Level{SmallBlind=800, BigBlind=1600} },
            {13, new Level{SmallBlind=1000, BigBlind=2000} },
        };

        public Dictionary<int, Level> BlindStructureLoader()
        {
            Dictionary<int, Level> BlindStructure = new Dictionary<int, Level>();
            foreach (KeyValuePair<int, Level> kvp in DefaultStructure)
            {
                BlindStructure.Add(kvp.Key, kvp.Value);
            }
            return BlindStructure;
        }

    }
}
