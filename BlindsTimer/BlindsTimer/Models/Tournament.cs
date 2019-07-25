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

        public int CurrentLevel { get; set; }

        public int LevelMinutes { get; set; }
        public TimeSpan LevelTime { get; set; }
        public int LevelSeconds = 0;

        public int BreakFrequency { get; set; }

        public TimeSpan BreakLength { get; set; }

        public Dictionary<int, Level>BlindStructure { get; set; }

        //this is applied in the controller
        public TimeSpan GetLevelTime(int LevelLength)
        {
            TimeSpan Container = new TimeSpan(0, LevelLength, 0);
            LevelTime = Container;
            return LevelTime;
        }
        
        public void LevelTimer(object sender, ElapsedEventArgs e)
        {
            TimeSpan OneSecond = new TimeSpan(0, 0, 1);
            LevelTime = LevelTime - OneSecond;
            LevelTimeRemaining();
           
        }
        //gets the ball rolling
        public void Start()
        {
            Timer Blindtimer = new Timer(1000);
            Blindtimer.Elapsed += new ElapsedEventHandler(LevelTimer);
            Blindtimer.Enabled = true;
        }

        public TimeSpan LevelTimeRemaining()
        {
            return LevelTime;
        }
    }
}
