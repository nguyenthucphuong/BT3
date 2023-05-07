using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, fibo;
            while (true)
            {
                Console.Write("Nhập số nguyên n >= 0, n = ");
                if ((int.TryParse(Console.ReadLine(), out n) && n > 0)) break;
                Console.Write("Không hợp lệ!");
            }
            Console.Write("Dãy Fibonacci với {0} phần tử là: ", n);
            for (int i = 1; i <= n; i++)
            {
                fibo = a;
                a = b;
                b = fibo + a;
                Console.Write(fibo + " ");
            }
            Console.ReadKey();

        }
    }
}
