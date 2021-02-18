using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter the text:");
            string lettersCount = Console.ReadLine();

            foreach (var item in lettersCount)
            {
                //it's 'a' and 'A' of Latin and Cyrillic!
                if (item == 'a' || item == 'A' || item == 'а' || item == 'А')
                {
                    count++;
                }
            }

            Console.WriteLine("The numbers of letters 'a' or 'A' in this line: " + count);
        }
    }
}