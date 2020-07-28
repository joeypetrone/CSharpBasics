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
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var animal in animals)
            {
                int count = 0;

                foreach (var c in animal)
                {
                    if(vowels.Contains(c))
                    {
                        count++;
                    }
                }

                if (animal.Contains("ou"))
                {
                    count--;
                }

                if (count == 2)
                {
                    Console.WriteLine(animal);
                }

            }
        }
    }
}
