using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TimeEntry
{
    public class RandomTimeEntry : ITimeEntry
    {
        private readonly Random random = new Random(DateTime.Now.Second); //Different seed for different results
        public int GetAthleteTimeInSeconds()
        {
            return random.Next(80, 120); //Just admitting that the normal course time is between 80 and 120
        }
     }
}
