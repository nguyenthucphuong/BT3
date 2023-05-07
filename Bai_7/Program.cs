using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            while (true)
            {
                Console.Write("Nhập số nguyên n > 0, n = ");
                if ((int.TryParse(Console.ReadLine(), out n) && n > 0)) break;
                Console.Write("Không hợp lệ!");
            }
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Tổng các số lẻ từ 1 đến {0} là: {1}", n, sum);
            Console.ReadKey();

        }
    }
}
