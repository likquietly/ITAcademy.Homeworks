using System;
using static System.Console;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength, arrValue, arrIndex;

            Write("Enter the array size: ");
            while (!Int32.TryParse(ReadLine(), out arrLength))
            {
                Write("You entered the wrong array size, please, try again: ");
            }

            int[] userArr = new int[arrLength];

            WriteLine($"Enter {userArr.Length} values for user array:");
            for (int i = 0; i < userArr.Length - 1; i++)
            {
                Write($"{i + 1} element: ");
                while (!Int32.TryParse(ReadLine(), out userArr[i]))
                {
                    Write("You enter the invalid number, please, try again: ");
                }
            }

            WriteLine($"Original user array: {string.Join(" ", userArr)}");

            WriteLine("Enter one more array value:");
            while (!Int32.TryParse(ReadLine(), out arrValue))
            {
                Write("You enter the invalid value, please, try again: ");
            }

            WriteLine("Enter the element index of the array: ");
            while (!Int32.TryParse(ReadLine(), out arrIndex))
            {
                Write("You enter the invalid index, please, try again: ");
            }

            for (int i = userArr.Length - 1; i >= arrIndex; i--)
            {
                userArr[i] = i == arrIndex ? arrValue : userArr[i - 1];
            }

            WriteLine($"Final user array: {string.Join(" ", userArr)}");
        }
    }
}