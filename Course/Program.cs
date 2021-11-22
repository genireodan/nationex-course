using Course.Course;
using Course.NameEntry;
using Course.TimeEntry;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            INameEntry nameEntry = SelectNameEntryMode();
            ITimeEntry timeEntry = SelectTimeEntryMode();
            ICourse course = new Course.Course(5, nameEntry, timeEntry);

            course.InitCourse();
            course.ShowResults();
        }

        static INameEntry SelectNameEntryMode()
        {
            Console.WriteLine("Select the Name entry method");
            Console.WriteLine("==> 1: Hard Coded Names");
            Console.WriteLine("==> 2: Manual Typing Name");
            int.TryParse(Console.ReadLine(), out int choice);
            switch(choice)
            {
                case 1:
                    return new HardCodedNameEntry();
                case 2:
                    return new ConsoleNameEntry();
                default:
                    return new HardCodedNameEntry(); // for simplicity we don't manage errors, so if choice is different or tryparse is false, we will return this default value
            }
        }

        static ITimeEntry SelectTimeEntryMode()
        {
            Console.WriteLine("Select the Time entry method");
            Console.WriteLine("==> 1: Hard Coded Times");
            Console.WriteLine("==> 2: Manual Typing Time");
            Console.WriteLine("==> 3: Random Generated Time");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    return new HardCodedTimeEntry();
                case 2:
                    return new ConsoleTimeEntry();
                case 3:
                    return new RandomTimeEntry();
                default:
                    return new HardCodedTimeEntry(); // for simplicity we don't manage errors, so if choice is different or tryparse is false, we will return this default value
            }
        }
    }
}
