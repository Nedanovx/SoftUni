using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> isLessOrEqual = (name, lenght) => name.Length <= lenght;
            string[] result = names.Where(x => isLessOrEqual(x, number)).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
