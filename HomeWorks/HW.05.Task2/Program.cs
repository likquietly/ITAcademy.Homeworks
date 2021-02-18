using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte userDefined;

            Console.Write("Enter a number from 1 to 100: ");
            while (!byte.TryParse(Console.ReadLine(), out userDefined) || (userDefined < 1) || (userDefined > 100))
            {
                Console.Write("You entered a wrong number, please, try again: ");
            }

            for (int i = 1; i <= userDefined; i++)
            {
                for (int j = userDefined; j >= i; j--)
                {
                    Console.Write(i < 10 ? $" {i}" : $" {i % 10}");
                }
                Console.WriteLine();

                //offset before each new line
                for (int k = i; k != 0; k--)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}