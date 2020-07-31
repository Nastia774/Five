using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zp = 5500;
            double prem;
            Console.Write("Введите сколько лет вы работали: ");
            int year = int.Parse(Console.ReadLine());
            if (year < 5)
            {
                prem = zp * 0.1;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            else if (5 <= year && year < 10)
            {
                prem = zp * 0.15;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            else if (10 <= year && year < 15)
            {
                prem = zp * 0.25;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            else if (15 <= year && year < 20)
            {
                prem = zp * 0.35;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            else if (20 <= year && year < 25)
            {
                prem = zp * 0.45;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            else if (25 <= year)
            {
                prem = zp * 0.5;
                Console.WriteLine($"Ваша премия состовляет {prem}");
            }
            Console.ReadKey();
        }
    }
}
