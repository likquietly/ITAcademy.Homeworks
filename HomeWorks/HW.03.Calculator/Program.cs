using System;

namespace HW._03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number for method Add:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number for method Add: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number for method Minus:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number for method Minus: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number for method Multiply:");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number for method Multiply: ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number for method Divide:");
            double num7 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number for method Divide: ");
            double num8 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number for method RemOfDiv:");
            double num9 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number for method RemOfDiv: ");
            double num10 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle for method Square:");
            double num11 = Double.Parse(Console.ReadLine());

            Calculator FirstObj = new Calculator();

            FirstObj.Add(num1, num2);
            FirstObj.Minus(num3, num4);
            FirstObj.Multiply(num5, num6);
            FirstObj.Divide(num7, num8);
            FirstObj.RemOfDiv(num9, num10);
            FirstObj.Square(num11);
        }
    }
}
