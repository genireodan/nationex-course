using Course.NameEntry;
using Course.TimeEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Course
{
    public class Course : ICourse
    {
        private readonly int numberOfParticipants;
        private readonly int numberOfPodium;
        private readonly INameEntry nameEntry;
        private readonly ITimeEntry timeEntry;
        private List<Athlete> athletes;

        public Course(int numberOfParticipants, INameEntry nameEntry, ITimeEntry timeEntry)
        {
            this.numberOfParticipants = numberOfParticipants;
            this.nameEntry = nameEntry;
            this.timeEntry = timeEntry;
            numberOfPodium = 3;
        }

        public void InitCourse()
        {
            athletes = new List<Athlete>();
            for(int i = 0; i < numberOfParticipants; i++)
            {
                athletes.Add(new Athlete(nameEntry.GetAthleteName(), timeEntry.GetAthleteTimeInSeconds()));
            }
        }

        public void ShowResults()
        {
            Console.WriteLine("RESULTS OF THE COURSE");
            athletes.Sort((x, y) => x.TimeInSeconds.CompareTo(y.TimeInSeconds));
            for(int i = 0; i < numberOfPodium; i++)
            {
                Console.WriteLine(athletes[i]);
            }
        }
    }
}
