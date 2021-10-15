using System;

namespace Avt_2
{
    class Program
    {

        static string[] Ecchi(string y, int g, string x = "")
        {
            string[] s1 = new string[g];
            int k = 0;
            for (int i = 0; i < y.Length; i++)
            {
                s1[k] += y[i];
                if (Convert.ToString(y[i]).ToLower() == x) k += 1;
            }
            return s1;
        }

        static void Main(string[] args)
        {
            string[] gg = Ecchi("A B C D E ", 5, " ");
            int d = 0;
            foreach (string x in gg)
            {

                Console.SetCursorPosition(Console.WindowWidth - gg[d].Length, d);
                Console.WriteLine(x);
                d += 1;
            }
        }
    }
}