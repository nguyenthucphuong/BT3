using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
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
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
            Console.ReadKey();

        }
    }
}
