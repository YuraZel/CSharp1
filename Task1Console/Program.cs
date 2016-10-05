using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите а:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Периметр: " + (2 * a + 2 * b));
            Console.WriteLine("Площа:    " + (a * b));
            // c = Math.pow(10, -2.0);
            //  Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
