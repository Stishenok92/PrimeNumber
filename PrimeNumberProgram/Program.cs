using System;
using System.ComponentModel.DataAnnotations;
using static PrimeNumberLibrary.PrimeNumber;

namespace PrimeNumberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task \"Prime number\"\n");

            try
            {
                Console.Write("Enter natural number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Answer: " + ValidationPrimeNumber(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}