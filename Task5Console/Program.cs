using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, t, y, z;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z:");
            z = Convert.ToDouble(Console.ReadLine());
            t = 2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - z * z / 5));
            Console.WriteLine("t= " + t);
            Console.ReadKey();
        }
    }
}
