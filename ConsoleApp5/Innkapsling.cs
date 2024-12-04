using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleOppgaver1
{
    internal class Innkapsling
    {
        private string _name;

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetName()
        {
            return _name;
        }

        public void CreateName()
        {
            var person1 = new Innkapsling();
            person1.SetName("Per");

            Console.WriteLine("Navn: " + person1.GetName());
        }
    }
    
}
