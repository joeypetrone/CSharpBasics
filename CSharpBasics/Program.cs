﻿using System;
using System.Collections;
using System.Collections.Concurrent;
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

            //Console.WriteLine(@"
            //                             ____       ___                 ____
            //                            /    \     /   \     |         /    \   
            //                            |         |_____|    |         |  
            //                            \____/    |     |    |____/    \____/


            //This program allows you to calculate in different ways:

            //    - Multiply a group of numbers by using the * operator ( * 1,2,3 would equal 6 )
            //    - Square each number in the group by using the ^2 operator ( ^2 1,2,3 would equal 1,4,9 )
            //    - Add the numbers in the group by ising the + operator ( + 1,2,3 would equal 6 )
            //    - Divide the numbers in the group by using the / operator ( / 6,3 would equal 2 )
            //    - Get the average of the group of numbers by using the avg operator ( avg 1,2,3 would equal 2 )

            //            ");

            string tryAgain = null;
            //do
            //{
            //    Console.WriteLine("Please input the operator followed by a space and then 3 numbers 1-10 separated by commas:");
            //    var numInput = Console.ReadLine();
            //    Console.WriteLine(" ");

            //    var choices = numInput.Split(" ");
            //    string operatorChoice = choices[0];
            //    string numberList = choices[1];



            //    // Check to see which kind of operator was used and save that operator to a variable
            //    // Save the comma separated number list to a variable
            //    if (numInput.Substring(0, 1) == "^")
            //    {
            //        operatorChoice = numInput.Substring(0, 2);
            //        numberList = numInput.Substring(3);
            //    }
            //    else if (numInput.Substring(0, 3) == "avg")
            //    {
            //        operatorChoice = numInput.Substring(0, 3);
            //        numberList = numInput.Substring(4);
            //    }
            //    else if (numInput.Substring(0, 1) != "")
            //    {
            //        operatorChoice = numInput.Substring(0, 1);
            //        numberList = numInput.Substring(2);
            //    }


            //    // Remove the commas in the number list
            //    var numbersOnly = numberList.Split(",");

            //    // Initiate a funcion based on it's operator
            //    switch (operatorChoice)
            //    {
            //        case "*": /// Multiplication
            //            var product = 1;

            //            foreach (var n in numbersOnly)
            //            {
            //                var multiplicand = int.Parse(n);

            //                product *= multiplicand;
            //            }

            //            Console.WriteLine($"The product of {numberList} is {product}");
            //            break;

            //        case "^2": // Square Root
            //            StringBuilder squaredNumbers = new StringBuilder();

            //            for (int i = 0; i < numbersOnly.Length; i++)
            //            {
            //                int result = 1;

            //                var multiplicand = int.Parse(numbersOnly[i]);

            //                result = multiplicand * multiplicand;

            //                squaredNumbers.Append(result.ToString());

            //                if (i < numbersOnly.Length - 1)
            //                {
            //                    squaredNumbers.Append(",");
            //                }
            //            }

            //            Console.WriteLine($"{numberList} squared is {squaredNumbers}");
            //            break;
            //        case "+": // Addition
            //            var sum = 0;

            //            foreach (var n in numbersOnly)
            //            {
            //                var addend = int.Parse(n);

            //                sum += addend;
            //            }

            //            Console.WriteLine($"The sum of {numberList} is {sum}");
            //            break;
            //        case "/": // Division
            //            var quotient = 1f;

            //            for (int i = 0; i < numbersOnly.Length; i++)
            //            {
            //                if (i == 0)
            //                {
            //                    float dividend = float.Parse(numbersOnly[i]);
            //                    float divisor = float.Parse(numbersOnly[i + 1]);

            //                    quotient = dividend / divisor;
            //                }
            //                else if (i + 1 < numbersOnly.Length)
            //                {
            //                    float divisor = float.Parse(numbersOnly[i + 1]);

            //                    quotient /= divisor;
            //                }
            //            }
            //            Console.WriteLine($"The quotient of {numberList} is {quotient}");
            //            break;
            //        case "avg": // Average
            //            var average = 1f;

            //            var avgSum = 0f;

            //            foreach (var n in numbersOnly)
            //            {
            //                float avgAddend = int.Parse(n);

            //                avgSum += avgAddend;
            //            }

            //            average = avgSum / numbersOnly.Length;

            //            Console.WriteLine($"The average of {numberList} is {average}");
            //            break;
            //        default: // Console error if incorrect operator
            //            Console.WriteLine("ERROR: Incorrect operator");
            //            break;
            //    }

            //    Console.WriteLine(" ");
            //    Console.WriteLine("Would you like to try it again? (Y or N)");
            //    tryAgain = Console.ReadLine();
            //    Console.WriteLine(" ");
            //} while (tryAgain.ToLower() != "n");

            // LETTER LOOPS //

            //Console.WriteLine("LETTER LOOPS!!");
            //Console.WriteLine(" ");

            //do
            //{
            //    Console.WriteLine("Enter your favorite lowercase or uppercase letters with no spaces inbetween: ");
            //    var letterLoopInput = Console.ReadLine();

            //    var letterLoopOutput = "";
            //    for (var i=0; i < letterLoopInput.Length; i++)
            //    {
            //        letterLoopOutput += letterLoopInput[i].ToString().ToUpper();

            //        for (var j=0; j < i; j++)
            //        {
            //            letterLoopOutput += letterLoopInput[i].ToString().ToLower();
            //        }

            //        if (i < letterLoopInput.Length - 1)
            //        {
            //            letterLoopOutput += "-";
            //        }
            //    }

            //    Console.WriteLine($"{letterLoopOutput}");

            //    Console.WriteLine(" ");
            //    Console.WriteLine("Would you like to try it again? (Y or N)");
            //    tryAgain = Console.ReadLine();
            //    Console.WriteLine(" ");
            //} while (tryAgain.ToLower() != "n");

            // MASK SENSITIVE INFORMATION //

            //do
            //{
            //    Console.WriteLine("Enter a secret word: ");
            //    var maskInfoInput = Console.ReadLine();

            //    var maskInfoOutput = "";
            //    for (var i=0; i < maskInfoInput.Length; i++)
            //    {
            //        if (maskInfoInput.Length <= 4)
            //        {
            //            maskInfoOutput += "*";
            //        } 
            //        else if (i < maskInfoInput.Length - 4)
            //        {
            //            maskInfoOutput += "*";
            //        }
            //        else
            //        {
            //            maskInfoOutput += maskInfoInput[i];
            //        }
            //    }

            //    Console.WriteLine($"{maskInfoOutput}");

            //    Console.WriteLine(" ");
            //    Console.WriteLine("Would you like to try it again? (Y or N)");
            //    tryAgain = Console.ReadLine();
            //    Console.WriteLine(" ");
            //} while (tryAgain.ToLower() != "n");

            // VALIDATOR //

            Console.WriteLine("Welcome to the Validator program!");
            Console.WriteLine(" ");

            do
            {
                // Pin validation
                if (pinValidator())
                {
                    Console.WriteLine("That is a valid pin, thank you.");
                }
                else
                {
                    Console.WriteLine("That pin has an invalid format.");
                }
                Console.WriteLine(" ");

                // Phone number validation
                //if (phoneNumberValidator())
                //{
                //    Console.WriteLine("That is a valid phone number, thank you.");
                //}
                //else
                //{
                //    Console.WriteLine("That phone number has an invalid format.");
                //}
                //Console.WriteLine(" ");

                // Email address validation
                //if (emailValidator())
                //{
                //    Console.WriteLine("That is a valid email address, thank you.");
                //}
                //else
                //{
                //    Console.WriteLine("That email address has an invalid format.");
                //}

                Console.WriteLine(" ");
                Console.WriteLine("Would you like to try Validator again? (Y or N)");
                tryAgain = Console.ReadLine();
                Console.WriteLine(" ");
            } while (tryAgain.ToLower() != "n");

            // Pin validator method
            static bool pinValidator()
            {
                Console.WriteLine("Enter a pin code: ");
                var pinInput = Console.ReadLine();

                bool pinIsOnlyDigits = digitChecker(pinInput);

                bool pinIsValid = false;

                if (pinInput.Length >= 4 && pinInput.Length <= 8 && pinIsOnlyDigits)
                {
                    pinIsValid = true;
                }
                else
                {
                    pinIsValid = false;
                }

                return pinIsValid;
            }

            // Phone number validator method
            static bool phoneNumberValidator()
            {
                Console.WriteLine("Enter a phone number: ");
                var phoneNumberInput = Console.ReadLine();

                bool phoneNumberIsValid = phoneNumberChecker(phoneNumberInput);

                return phoneNumberIsValid;
            }

            // Email address validator method
            static bool emailValidator()
            {
                Console.WriteLine("Enter an email address: ");
                var emailInput = Console.ReadLine();

                bool emailIsValid = false;
                for (var i = 0; i < emailInput.Length; i++)
                {
                    if (emailInput.Length >= 4 && emailInput.Length <= 8)
                    {

                        emailIsValid = true;
                    }
                    else
                    {
                        emailIsValid = false;
                    }
                }

                return emailIsValid;
            }

            // Checks if the phone number string is in correct format
            static bool phoneNumberChecker(string phoneNumber)
            {
                bool validPhoneNumber = false;

                string symbolList = "() -";

                if (digitChecker(phoneNumber))
                {
                    validPhoneNumber = containsTen(phoneNumber);
                }
                else
                {
                    foreach (var c in phoneNumber)
                    {
                        if (symbolList.Contains(c))
                        {
                            //containsCorrectSymbols = true;
                        }
                        else
                        {
                            //containsCorrectSymbols = false;
                        }
                    }
                }

                // Checks if the string has exactly 10 chacters
                static bool containsTen(string number)
                {
                    if (number.Length == 10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return validPhoneNumber;
            }

            // Checks if the input has only numbers in the string
            static bool digitChecker(string input)
            {
                Regex regex = new Regex("^[0-9]+$");

                Match match = regex.Match(input);

                return match.Success;
            }
        }
    }
}
