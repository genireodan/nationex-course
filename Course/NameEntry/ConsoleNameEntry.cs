using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.NameEntry
{
    public class ConsoleNameEntry : INameEntry
    {
        public string GetAthleteName()
        {
            Console.WriteLine("==> Enter Athlete Name: ");
            var name = Console.ReadLine();
            return name;
        }
    }
}
