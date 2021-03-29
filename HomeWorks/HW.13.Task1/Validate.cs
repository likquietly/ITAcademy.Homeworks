using System;

namespace HW._13.Task1
{
    class Validate
    {
        public static int ValidateInt()
        {
            int value;
            while (!Int32.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Please enter a valid value");
            }
            return value;
        }
    }
}