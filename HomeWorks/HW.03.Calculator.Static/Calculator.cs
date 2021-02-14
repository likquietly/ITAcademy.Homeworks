using System;

namespace HW._03.Calculator.Static
{
    class Calculator
    {
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"The result of adding {num1} and {num2}: {num1 + num2}");
        }

        public static void Minus(double num1, double num2)
        {
            Console.WriteLine($"The result of subtracting {num2} from {num1}: {num1 - num2}");
        }

        public static void Multiply(double num1, double num2)
        {
            Console.WriteLine($"The result of multiplying {num1} by {num2}: {num1 * num2}");
        }

        public static void Divide(double num1, double num2)
        {
            Console.WriteLine($"The result of dividing {num1} by {num2}: {num1 / num2}");
        }

        //method for finding the remainder of two double numbers
        public static void RemOfDiv(double num1, double num2)
        {
            Console.WriteLine($"The remainder of {num1} divided by {num2}: {num1 % num2}");
        }

        ////method for finding the area of ​​a circle
        public static void Square(double num1)
        {
            Console.WriteLine($"Area of a circle with radius {num1}: {Math.PI * Math.Pow(num1, 2)}");
        }
    }
}
