using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double point1 = CloserToTheCenter(x1, y1, 0, 0);
            double point2 = CloserToTheCenter(x2, y2, 0, 0);
            if (point1 < point2)
            {
                Console.WriteLine($"({x1}, {y1})");
            } 
            else if (point2 < point1)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        private static double CloserToTheCenter(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
        }
    }
}
