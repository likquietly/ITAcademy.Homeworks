using System;

namespace HW._07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line separating lines with semicolon separator:");
            string text = Console.ReadLine();

            //'O' and 'A' in Latin and Cyrillic, respectively
            text = text.Replace('\u004f', '\u0041').Replace('\u041E', '\u0410');

            string[] textArr = text.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in textArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}