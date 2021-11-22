using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TimeEntry
{
    public class HardCodedTimeEntry : ITimeEntry
    {
        private readonly List<int> times = new List<int> { 100, 98, 105, 93, 102 };
        private int nextTimeIndex = 0;
        public int GetAthleteTimeInSeconds()
        {
            var time = times[nextTimeIndex++];
            if (nextTimeIndex >= times.Count)
            {
                nextTimeIndex = 0;
            }
            return time;
        }
    }
}
