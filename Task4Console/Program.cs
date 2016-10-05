using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, f, z, y;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z:");
            z = Convert.ToDouble(Console.ReadLine());
            f = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4) / Math.Abs(x - y) / (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));
            Console.WriteLine("f= " + f);
            Console.ReadKey();
        }
    }
}
