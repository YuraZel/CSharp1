using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b, y;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + 1.0 / 100 * (x - b); ;
            Console.WriteLine("y= " + y);
            Console.ReadKey();
        }
    }
}
