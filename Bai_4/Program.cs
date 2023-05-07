using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Nhập số nguyên n > 0, n = ");
                if ((int.TryParse(Console.ReadLine(), out n) && n > 0)) break;
                Console.Write("Không hợp lệ!");
            }
            string s = " không";
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (i * i == n)
                {
                    s = "";
                    break;
                }
            }
            Console.WriteLine("{0}{1} là số chính phương", n, s);
            Console.ReadKey();

        }
    }
}
