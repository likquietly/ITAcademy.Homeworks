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
                //it's 'A' and 'a' of Latin and 'А' and 'а' of Cyrillic respectively
                if (item == '\u0041' || item == '\u0061' || item == '\u0410' || item == '\u0430')
                {
                    count++;
                }
            }

            Console.WriteLine("The numbers of letters 'a' or 'A' in this line: " + count);
        }
    }
}