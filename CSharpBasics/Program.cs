using System;
using System.Collections;
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
            Console.WriteLine(" ");
            Console.WriteLine("Animals with two syllabols: ");

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

            Console.WriteLine(" ");

            var greetings = new string[] { "Howdy, How yall doing this fine morning?", "Good morning, now get to work", "Hey" };

            Console.WriteLine("Please select a greeting: ");
            for ( var i=0; i < greetings.Length; i++)
            {
                Console.WriteLine($"{i+1}. {greetings[i]}");
            }

            string input;

            do
            {
                input = Console.ReadLine();
                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine($"Select a value 1 thru {greetings.Length}");
                }

            } while (input != "1" && input != "2" && input != "3");

            var response = @$"You chose greeting {input}
                             {greetings[int.Parse(input)-1]}";
            Console.WriteLine(response);
        }
    }
}
