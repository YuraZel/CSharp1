using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n, z1, z2;
            Console.WriteLine("Введите m:");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите n:");
            n = Convert.ToDouble(Console.ReadLine());
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine("z1= " + z1);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("z2= " + z2);
            Console.ReadKey();
        }
    }
}
