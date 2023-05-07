using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Nhập số nguyên n > 0, n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
                Console.Write("Không hợp lệ!");
            }
            if (n >= 2) Console.Write("Các số nguyên tố từ 1 đến {0} là: 2 ", n);
            else Console.Write("Không có số nguyên tố");
            for (int i = 3; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
