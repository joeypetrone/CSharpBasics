using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //--- HELLO WORLD & CONSOLE INPUT ---//

            //Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?
            //Console.WriteLine(" ");
            //Console.WriteLine("What is your name?");
            //var userName = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine($"Good day to you, {userName}!");
            //Console.WriteLine(" ");

            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            //Console.WriteLine("What is your favorite color?");
            //var favColor = Console.ReadLine();
            //Console.WriteLine(" ");
            ////Create a Random object
            //Random rand = new Random();
            //// Generate random index less than the size of the array
            //int index = rand.Next(animals.Length);
            //Console.WriteLine($"Would you like to have a {favColor} {animals[index]}!");
            //Console.WriteLine(" ");
            //Console.WriteLine("Animals with two syllabols: ");


            //var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            //foreach (var animal in animals)
            //{
            //    int count = 0;

            //    foreach (var c in animal)
            //    {
            //        if (vowels.Contains(c))
            //        {
            //            count++;
            //        }
            //    }

            //    if (animal.Contains("ou"))
            //    {
            //        count--;
            //    }

            //    if (count == 2)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //}

            //Console.WriteLine(" ");

            //var greetings = new string[] { "Howdy, How yall doing this fine morning?", "Good morning, now get to work", "Hey" };

            //Console.WriteLine("Please select a greeting: ");
            //for (var i = 0; i < greetings.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {greetings[i]}");
            //}

            //string input;

            //do
            //{
            //    input = Console.ReadLine();
            //    if (input != "1" && input != "2" && input != "3")
            //    {
            //        Console.WriteLine($"Select a value 1 thru {greetings.Length}");
            //    }

            //} while (input != "1" && input != "2" && input != "3");

            //var response = @$"You chose greeting {input}
            //                 {greetings[int.Parse(input) - 1]}";
            //Console.WriteLine(response);

            //--- CALCULATOR ---//

            string tryAgain = null;
            do
            {
                Console.WriteLine("Please input 3 numbers 1-10 separated by commas:");
                var numInput = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to (m) multiply or (s) square these numbers?");
                var operationChoice = Console.ReadLine();
                Console.WriteLine(" ");

                var newNumbers = numInput.Split(",");

                var product = 1;

                StringBuilder squaredNumbers = new StringBuilder();

                if (operationChoice.ToLower() == "m")
                {
                    foreach (var n in newNumbers)
                    {
                        var multiplicand = int.Parse(n);

                        product *= multiplicand;
                    }

                    Console.WriteLine($"The product of {numInput} is {product}");


                } else if (operationChoice.ToLower() == "s")
                {
                    for (int i = 0; i < newNumbers.Length; i++)
                    {
                        int result = 1;

                        var multiplicand = int.Parse(newNumbers[i]);

                        result = multiplicand * multiplicand;

                        squaredNumbers.Append(result.ToString());

                        if (i < newNumbers.Length - 1)
                        {
                            squaredNumbers.Append(",");
                        }
                    }

                    Console.WriteLine($"{numInput} are {squaredNumbers.ToString()} when squared");

                }

                Console.WriteLine(" ");
                Console.WriteLine("Would you like to try it again? (Y or N)");
                tryAgain = Console.ReadLine();
                Console.WriteLine(" ");
            } while (tryAgain.ToLower() != "n");
        }
    }
}
