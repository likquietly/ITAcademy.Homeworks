﻿using System;

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
            Console.Write("Enter the calculation result: ");
            double result = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(result == firstNumber + secondNumber ? "correct" : "incorrect");

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
    }
}