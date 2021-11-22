using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TimeEntry
{
    public class ConsoleTimeEntry : ITimeEntry
    {
        public int GetAthleteTimeInSeconds()
        {
            Console.WriteLine("==> Enter Athlete Time: ");
            var parsed = int.TryParse(Console.ReadLine(), out int time);
            return parsed && time > 0 ? time : 100; //Default value is 100 seconds if parse not working or value is negative, just for simplicity
        }
    }
}
