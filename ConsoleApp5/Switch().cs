using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleOppgaver1
{
    internal class Class3
    {
        public static void Switch()
        {
            Console.WriteLine("Hva er 2 x 1?");
            var userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Feil, prøv igjen!");
                    break;
                case "2":
                    Console.WriteLine("Du har rett, kjempe bra!");
                    break;
                default:
                    Switch();
                    break;
            }
        }
    }
}
