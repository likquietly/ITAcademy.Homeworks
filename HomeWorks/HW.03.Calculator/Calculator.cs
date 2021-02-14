using System;

namespace HW._03.Calculator
{
    class Calculator
    {
        public void Add(double num1, double num2)
        {
            Console.WriteLine($"The result of adding {num1} and {num2}: {num1 + num2}");
        }

        public void Minus(double num1, double num2)
        {
            Console.WriteLine($"The result of subtracting {num2} from {num1}: {num1 - num2}");
        }

        public void Multiply(double num1, double num2)
        {
            Console.WriteLine($"The result of multiplying {num1} by {num2}: {num1 * num2}");
        }

        public void Divide(double num1, double num2)
        {
            Console.WriteLine($"The result of dividing {num1} by {num2}: {num1 / num2}");
        }

        //method for finding the remainder of two double numbers
        public void RemOfDiv(double num1, double num2)
        {
            Console.WriteLine($"The remainder of {num1} divided by {num2}: {num1 % num2}");
        }

        ////method for finding the area of ​​a circle
        public void Square(double num1)
        {
            Console.WriteLine($"Area of a circle with radius {num1}: {Math.PI * Math.Pow(num1, 2)}");
        }
    }
}
