using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            int day = 28;
            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            while (true)
            {
                Console.Write("Nhập tháng là số nguyên (1 - 12), tháng = ");
                if (int.TryParse(Console.ReadLine(), out month) && month > 0 && month < 13) break;
                Console.Write("Không hợp lệ!");
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if (isLeapYear) day = 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
            }
            Console.WriteLine("Tháng {0} có {1} ngày", month, day);
            Console.ReadKey();
        }
    }
}
