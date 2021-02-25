using System;

namespace HW._07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "gdfgdf234dg54gf/23oP42";

            string numbTemp = string.Empty;
            double number1 = 0.0;
            char sym = ' ';

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    numbTemp += text[i];
                }
                else if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
                {
                    sym = text[i];
                    number1 = Convert.ToDouble(numbTemp);
                    numbTemp = string.Empty;
                }
            }

            double number2 = Convert.ToDouble(numbTemp);

            switch (sym)
            {
                case '+':
                    Console.WriteLine($"{number1} {sym} {number2} = {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"{number1} {sym} {number2} = {number1 - number2}");
                    break;
                case '*':
                    Console.WriteLine($"{number1} {sym} {number2} = {number1 * number2}");
                    break;
                case '/':
                    Console.WriteLine($"{number1} {sym} {number2} = {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Inputted an invalid arithmetic symbol");
                    break;
            }
        }
    }
}