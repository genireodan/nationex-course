using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Athlete
    {
        public Athlete(string name, int timeInSeconds)
        {
            Name = name;
            TimeInSeconds = timeInSeconds;
        }

        public string Name { get; set; }
        public int TimeInSeconds { get; set; }

        public override string ToString()
        {
            return $"--- Athlete {Name} finished with a time of {TimeInSeconds} seconds";
        }
    }
}
