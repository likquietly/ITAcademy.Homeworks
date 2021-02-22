using System;
using static System.Console;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;

            Write("Enter the array size: ");
            while (!Int32.TryParse(ReadLine(), out arrLength))
            {
                Write("You entered the wrong array size, please, try again: ");
            }

            int[] userArr = new int[arrLength];

            WriteLine($"Enter {userArr.Length} values for user array:");
            for (int i = 0; i < userArr.Length; i++)
            {
                Write($"{i + 1} element: ");
                while (!Int32.TryParse(ReadLine(), out userArr[i]))
                {
                    Write("You enter the invalid number, please, try again: ");
                }
            }

            WriteLine($"Original user array: {string.Join(" ", userArr)}");

            for (int i = 0; i < userArr.Length / 2; i++)
            {
                int temp = userArr[i];
                userArr[i] = userArr[userArr.Length - 1 - i];
                userArr[userArr.Length - 1 - i] = temp;
            }

            WriteLine($"Reverse user array: {string.Join(" ", userArr)}");
        }
    }
}