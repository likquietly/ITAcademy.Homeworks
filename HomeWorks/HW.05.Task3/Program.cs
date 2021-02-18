using System;

namespace HW._05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}");

            switch (true)
            {
                case true when DateTime.Now.Hour > 8 && DateTime.Now.Hour < 12:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case true when DateTime.Now.Hour > 11 && DateTime.Now.Hour < 15:
                    Console.WriteLine("Good day, guys!");
                    break;
                case true when DateTime.Now.Hour > 14 && DateTime.Now.Hour < 22:
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Unsupported range");
                    break;
            }
        }
    }
}