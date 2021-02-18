using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint userNumber;
            uint finalSumm = 0;

            Console.Write("Enter a positive number: ");
            while (!UInt32.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("You entered the wrong number, please, try again: ");
            }

            Console.Write($"{userNumber} => ");
            for (uint i = 1; i <= userNumber; i++)
            {
                finalSumm += i;
                Console.Write(i < userNumber ? $"{i} + " : $"{i}");
            }

            Console.WriteLine(" = " + finalSumm);
        }
    }
}