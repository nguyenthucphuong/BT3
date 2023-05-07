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
        while (true) {
            Console.Write("Nhập số nguyên n > 0, n = ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
            Console.Write("Không hợp lệ!");
        }
        // Dùng 2 vòng for
        Console.WriteLine("Tam giác vuông thuận:");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i + 1; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tam giác vuông ngược:");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tam giác đều thuận:");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n + i; j++) {
                if (j >= n - i - 1) Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tam giác đều ngược:");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < 2 * n - i - 1; j++) {
                if (j >= i) Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
        // Dùng lệnh PadRight
        string s = "";
        Console.WriteLine("Tam giác vuông thuận:");
        for (int i = 1; i <= n; i++) {
            Console.WriteLine(s.PadRight(i, '*'));
        }
        Console.WriteLine("Tam giác vuông ngược:");
        for (int i = n; i >= 1; i--) {
            Console.WriteLine(s.PadRight(i, '*'));
        }
        Console.WriteLine("Tam giác đều thuận:");
        for (int i = n; i <= 2 * n - 1; i++) {
            Console.Write(s.PadRight(2 * n - i - 1, ' '));
            Console.WriteLine(s.PadRight(2 * (i - n) + 1, '*'));
        }
        Console.WriteLine("Tam giác đều ngược:");
        for (int i = 2 * n - 1; i >= n; i--) {
            Console.Write(s.PadRight(2 * n - i - 1, ' '));
            Console.WriteLine(s.PadRight(2 * (i - n) + 1, '*'));
        }
        Console.ReadKey();
    }
}
}
