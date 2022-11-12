using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            double ax, ay, az, bx, by, bz, d;
            Console.Write("Ax = "); ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ay = "); ay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Az = "); az = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bx = "); bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("By = "); by = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bz = "); bz = Convert.ToDouble(Console.ReadLine());

            d = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
            
            Console.WriteLine("A({0},{1},{2}); B({3},{4},{5}) -> {6:0.00}", ax, ay, az, bx, by, bz, d);
            
            Console.ReadKey();
        }
    }
}

