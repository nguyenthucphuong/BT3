using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Nhập số nguyên n, n = ");
                if ((int.TryParse(Console.ReadLine(), out n))) break;
                Console.Write("Không hợp lệ!");
            }
            string s = " không";
            if (n % 3 == 0) s = "";
            Console.WriteLine("{0}{1} chia hết cho 3", n, s);
            Console.ReadKey();

        }
    }
}
