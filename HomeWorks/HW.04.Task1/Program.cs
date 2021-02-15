using System;

namespace HW._04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }

        /// <summary>
        /// Method for adding two numbers, checking for the entered value
        /// </summary>
        public static void Add()
        {
            double firstNumber, secondNumber;

            Console.Write("Enter the first number: ");
            while (!Double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("You entered an invalid first value, please, try again: ");
            }

            Console.Write("Enter the second number: ");
            while (!Double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.Write("You entered an invalid second value, please, try again: ");
            }

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
    }
}