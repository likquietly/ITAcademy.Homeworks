using System;

namespace HW._04.Task1
{
    class Program
    {
        static void Main(string[] args)
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

            Add(firstNumber, secondNumber);
        }

        /// <summary>
        /// Method for adding two numbers, checking for the entered value and result
        /// </summary>
        public static void Add(double firstNumber, double secondNumber)
        {
            double trueResult = firstNumber + secondNumber;

            Console.Write("Enter the calculation result: ");
            double result = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(result == trueResult ? "Correct" : "Incorrect");

            if (result < trueResult && result != trueResult)
            {
                Console.WriteLine("The number must be greater");
            }
            else if (result > trueResult && result != trueResult)
            {
                Console.WriteLine("The number must be less");
            }

            Console.WriteLine($"{firstNumber} + {secondNumber} = {trueResult}");
        }
    }
}