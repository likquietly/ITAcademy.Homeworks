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
        /// Method for adding or subtracting two numbers, checking for the entered value and result
        /// </summary>
        public static void Add()
        {
            double firstNumber, secondNumber;
            double trueResult = 0;
            char userOperator;

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

            Console.Write("Enter operator(+ or -): ");
            while (!Char.TryParse(Console.ReadLine(), out userOperator))
            {
                Console.Write("You entered an invalid operator, please, try again: ");
            }

            switch (userOperator)
            {
                case '+':
                    trueResult = firstNumber + secondNumber;
                    break;
                case '-':
                    trueResult = firstNumber - secondNumber;
                    break;
            }

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

            Console.WriteLine($"{firstNumber} {userOperator} {secondNumber} = {trueResult}");
        }
    }
}