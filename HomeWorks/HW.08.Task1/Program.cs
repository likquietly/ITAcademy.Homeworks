using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");

            bool secondPart = false;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '!' || sb[i] == '.' && !secondPart)
                {
                    sb.Remove(i, 1);
                    i--;
                }
                else if (sb[i] == '?' || secondPart)
                {
                    secondPart = true;
                    sb.Replace(' ', '_', i, 1);
                }
            }

            System.Console.WriteLine("String operation result: \n" + sb.ToString());
        }
    }
}