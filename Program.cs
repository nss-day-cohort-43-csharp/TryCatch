using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number: ");
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    // This line might throw a FormatException
                    int inputNum = int.Parse(input);
                    Console.WriteLine($"Your guess was {inputNum}");

                    // This line might throw a DivideByZeroException
                    Console.WriteLine(1000 / inputNum);

                    // Everything was successful. Break out of the while loop
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Not a valid number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Oh, and don't pick zero");
                }
            }

        }
    }
}