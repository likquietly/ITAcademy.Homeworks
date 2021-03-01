using System;
using System.Diagnostics;

namespace HW._06.Task3.Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] userArr = new long[100_000_000];

            Random rnd = new Random();

            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = rnd.Next(10);
            }

            Stopwatch stp = new Stopwatch();
            Stopwatch stp1 = new Stopwatch();

            stp.Start();
            Reverse(userArr);
            stp.Stop();
            Console.WriteLine($"The result of my method: {stp.ElapsedMilliseconds} ms, {stp.ElapsedTicks} Ticks");

            stp1.Start();
            Array.Reverse(userArr);
            stp1.Stop();
            Console.WriteLine($"The result of Microsoft method: {stp1.ElapsedMilliseconds} ms, {stp1.ElapsedTicks} Ticks");
        }

        public static void Reverse(long[] userArr)
        {
            int i = 0;
            int j = userArr.Length - 1 - i;

            for (; i < userArr.Length / 2; i++)
            {
                long temp = userArr[i];
                userArr[i] = userArr[j];
                userArr[j] = temp;
            }
        }
    }
}