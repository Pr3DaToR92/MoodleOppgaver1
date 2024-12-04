using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleOppgaver1
{
    internal class list
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public list(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}
