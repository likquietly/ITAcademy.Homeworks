using System;

namespace HW._09._10.Checkin
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            do
            {
                new MiniBot().SetName();
                Console.WriteLine(Constants.dialogMess);
                str = ConsoleChoose.Choose();
            } while (str.Equals("yes"));
        }
    }
}