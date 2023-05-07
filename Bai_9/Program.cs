using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9
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
            Console.WriteLine("Tam giác vuông thuận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tam giác vuông ngược:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tam giác đều thuận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + i; j++)
                {
                    if (j >= n - i - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tam giác đều ngược:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n - i - 1; j++)
                {
                    if (j >= i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
