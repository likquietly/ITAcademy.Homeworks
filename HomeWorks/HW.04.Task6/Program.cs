using System;

namespace HW._04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char moveSymbol;
            string answer;

            do
            {
                Console.WriteLine("In which direction move your character? (w/a/s/d)");
                do
                {
                    moveSymbol = Convert.ToChar(Console.Read());
                } while (moveSymbol != 'w' && moveSymbol != 'a' && moveSymbol != 's' && moveSymbol != 'd');

                switch (moveSymbol)
                {
                    case 'w':
                        Console.WriteLine("Your character has moved up 1 cell");
                        break;
                    case 'a':
                        Console.WriteLine("Your character has moved 1 cell to the left");
                        break;
                    case 's':
                        Console.WriteLine("Your character has moved down 1 cell");
                        break;
                    case 'd':
                        Console.WriteLine("Your character has moved 1 square to the right");
                        break;
                }

                Console.WriteLine("Would you like to move your character again? (Yes/No)");
                do
                {
                    answer = Console.ReadLine();
                } while (answer != "Yes" && answer != "No");
            } while (answer == "Yes");

            if (answer == "No")
                Console.WriteLine("No more movements required");
        }
    }
}