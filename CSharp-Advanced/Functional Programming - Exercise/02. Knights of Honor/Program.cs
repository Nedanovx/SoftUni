using System;
using System.Linq;
namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printName = name => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", name));
            string[] names = Console.ReadLine().Split();
            printName(names);
        }
    }
}
