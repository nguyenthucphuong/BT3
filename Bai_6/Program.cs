using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
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
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(i, i);
            }
            Console.WriteLine("Tong la: {0}", sum);
            Console.ReadKey();
        }
    }
}
