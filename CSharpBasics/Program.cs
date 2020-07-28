using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey(); // What happens if you run the app without this line?

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            var pattern = "[b-df-hj-np-tv-z]+";

            foreach (var animal in animals)
            {
                var syllables = Regex.Split(animal, pattern, RegexOptions.IgnoreCase);

                var combined = string.Concat(syllables);

                Console.WriteLine(combined);

                Console.WriteLine(syllables.Length);

                foreach (var i in syllables)
                {
                    Console.WriteLine(i);
                }

                if (combined.Length == 2)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
