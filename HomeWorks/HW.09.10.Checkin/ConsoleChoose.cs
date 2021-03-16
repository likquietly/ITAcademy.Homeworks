using System;

namespace HW._09._10.Checkin
{
    class ConsoleChoose
    {
        static string[] texts = new string[] { "-yes", "-no" };

        public static string Choose()
        {
            foreach (string text in texts)
            {
                Console.WriteLine(text);
            }

            int num = Keys();

            return num == 0 ? "yes" : "no";
            
        }

        private static void Text(int i)
        {
            Console.Clear();
            Console.WriteLine(Constants.dialogMess);

            for (int n = 0; n < texts.Length; n++)
            {
                if (n == i)
                    PrintColored(texts[n], ConsoleColor.Green);
                else
                    Console.WriteLine(texts[n]);
            }

            void PrintColored(string text, ConsoleColor foreground)
            {
                Console.ForegroundColor = foreground;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }

        private static int Keys()
        {
            int num = 0;
            bool flag = false;
            do
            {
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    num++;
                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    num--;
                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (num == -1)
                {
                    num = 1;
                    Text(1);
                }
                if (num == 2)
                {
                    num = 0;
                    Text(0);
                }
            } while (!flag);
            return num;
        }
    }
}