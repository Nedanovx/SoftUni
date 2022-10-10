using System;
using System.Collections.Generic;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double result1 = CloserToTheCenter(x1,  y1, x2, y2);
            double result2 = CloserToTheCenter(x3, y3, x4, y4);
            if (result1 >= result2)
            {
                if (CloserToTheCenter(x1, y1, 0, 0, 0, 0, 0, 0) <= CloserToTheCenter(x2, y2, 0, 0, 0, 0, 0, 0))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (CloserToTheCenter(x3, y3, 0, 0, 0, 0, 0, 0) <= CloserToTheCenter(x4, y4, 0, 0, 0, 0, 0, 0))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }


        }

        private static double CloserToTheCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double result1 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
            
            return result1;
        }
        private static double CloserToTheCenter(double x3, double y3, double x4, double y4)
        {

            double result2 = Math.Sqrt(Math.Pow(x4 - x3, 2.0) + Math.Pow(y4 - y3, 2.0));
            return result2;
        }
    }
}





        

  