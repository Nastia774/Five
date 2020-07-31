using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            {
                x += y >> x++ * z;
                Console.WriteLine($" x += y >> x++ * z = {x}"); //5
            }
            {
                z = ++x & y * 5;
                Console.WriteLine($" z = ++x & y * 5 = {z}"); //2
            }
            {
                y /= x + 5 | z;
                Console.WriteLine($" y /= x + 5 | z = {y}"); //0
            }
            {
                z = x++ & y * 5;
                Console.WriteLine($" z = x++ & y * 5 = {z}"); //0 
            }
            {
                x = y << x++ ^ z;
                Console.WriteLine($" x = y << x++ ^ z = {x}"); //0
            }
            Console.ReadKey();
        }
    }
}
