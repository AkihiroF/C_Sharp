using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avt_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b = 0;
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            while (a != 0)
            {
                b = b * 10 + a % 10;
                a /= 10;
            }
            Console.WriteLine((n == b) ? "Число симметричное." : "Число не симметричное.");
        }
    }
}
