using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
    //Random i C#
{
    internal class Class2
    {
        public static void Random()
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 3);
            if (randomNumber == 0)
            {
                Console.WriteLine("Tallet ble 0");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine("Tallet ble 1");
            }
            else
            {
                Console.WriteLine("Tallet ble 2");
            }
        }
        public static void RandomHobbyGenerator()
        {
            var name1 = "Varmi Ventili";
            var name2 = "Hårsår Harstadson";
            var name3 = "Shikara Wilhelmina";
            var name4 = "Angerbode Klausdottir";
            var input = Console.ReadLine();

            Random random = new Random();
            var randomNumber = random.Next(0, 4);
            if (randomNumber == 0)
            {
                Console.WriteLine($"{name1}: \nDu elsker å skru på bil!");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine($"{name1}: \nHallo...! Dette skal ikke gå.. men du ble nettopp den nye Statsministeren i England!");
            }
            else if (randomNumber == 2)
            {
                Console.WriteLine($"{name1}: \nJavel, så ble du en model da.");
            }
            else
            {
                Console.WriteLine($"{name1}: \nHeldige deg! Du har arvet Floki's evner til å bygge Viking båter");
            }
        }
    }
}
