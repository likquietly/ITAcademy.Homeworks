using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = new int[20];
            int[] userArr = new int[20];
            int[] summArr = new int[20];

            Random rnd = new Random();

            Console.WriteLine($"Enter {userArr.Length} values for user array");

            //if we know that all three arrays are the same size
            for (int i = 0; i < userArr.Length; i++)
            {
                Console.Write($"{i + 1} element: ");
                while (!Int32.TryParse(Console.ReadLine(), out userArr[i]))
                {
                    Console.Write("You enter the invalid number, please, try again: ");
                }
                randArr[i] = rnd.Next(20);
                summArr[i] = randArr[i] + userArr[i];
            }

            Console.WriteLine("Rand array: " + string.Join(" ", randArr));
            Console.WriteLine("User array: " + string.Join(" ", userArr));
            Console.WriteLine("Summ array: " + string.Join(" ", summArr));
        }
    }
}