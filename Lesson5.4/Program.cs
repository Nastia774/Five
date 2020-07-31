using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());

            if ((x & 1) == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }

            if (x % 2 == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey();
        }
    }
}
