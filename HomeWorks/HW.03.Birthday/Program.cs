using System;

namespace HW._03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month of your birth: ");
            byte monthBirth = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the year of your birth: ");
            short yearBirth = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the current month: ");
            byte currentMonth = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the current year: ");
            short currentYear = Convert.ToInt16(Console.ReadLine());

            byte age = Convert.ToByte(currentMonth >= monthBirth ? currentYear - yearBirth : currentYear - yearBirth - 1);
            Console.WriteLine($"Current age is: {age}");
        }
    }
}
