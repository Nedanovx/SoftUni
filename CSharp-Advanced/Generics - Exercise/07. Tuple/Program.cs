using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string> personInfo = new MyTuple<string, string>($"{person[0]} {person[1]}", person[2]);
            string[] beer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            MyTuple<string, int> beerInfo = new Tuple.MyTuple<string, int>(beer[0], int.Parse(beer[1]));
            string[] num = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            MyTuple<int, double> numbers = new Tuple.MyTuple<int, double>(int.Parse(num[0]), double.Parse(num[1]));

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbers);

        }
    }
}
