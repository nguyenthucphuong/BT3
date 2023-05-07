using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
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
            int sum = 0, fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            Console.WriteLine("Tổng giai thừa từ 1 đến {0} là: {1}", n, sum);
            Console.ReadKey();
        }
    }
}
