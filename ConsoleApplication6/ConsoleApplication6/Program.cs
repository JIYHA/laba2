using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            double d = (b * b - 4 * a * c);
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1=" + x1 + "x2=" + x2);

            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x=" + x);
            }
            else
            {
                Console.WriteLine("Answer is x + i * y");
                Console.WriteLine("Answer is x - i * y");
            }
        }
    }
}
