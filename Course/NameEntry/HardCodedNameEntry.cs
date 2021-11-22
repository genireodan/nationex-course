using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.NameEntry
{
    public class HardCodedNameEntry : INameEntry
    {
        private readonly List<string> names = new List<string> { "Runner 1", "Runner 2", "Runner 3", "Runner 4", "Runner 5" };
        private int nextNameIndex = 0;
        public string GetAthleteName()
        {
            var name = names[nextNameIndex++];
            if (nextNameIndex >= names.Count)
            {
                nextNameIndex = 0;
            }
            return name;
        }
    }
}
