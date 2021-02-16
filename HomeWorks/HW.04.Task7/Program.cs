using System;

namespace HW._04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int testIntTry;
            int testInt = Int32.Parse(Console.ReadLine());
            Int32.TryParse(Console.ReadLine(), out testIntTry);

            char testCharTry;
            char testChar = Char.Parse(Console.ReadLine());
            Char.TryParse(Console.ReadLine(), out testCharTry);

            bool testBoolTry;
            bool testBool = Boolean.Parse(Console.ReadLine());
            Boolean.TryParse(Console.ReadLine(), out testBoolTry);

            Console.WriteLine($"{testInt} {testIntTry} {testChar} {testCharTry} {testBool} {testBoolTry}");
        }
    }
}