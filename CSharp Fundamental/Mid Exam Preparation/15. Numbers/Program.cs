using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double averageSum = numbers.Sum() * 1.0/ numbers.Count;
            List<int> resultList = new List<int>();
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageSum)
                {
                    resultList.Add(numbers[i]);
                }
                
            }
            if (resultList.All(x=>x <= averageSum))
            {
                Console.WriteLine("No");
                
            }
            else if (resultList.Count < 5)
            {
                resultList.Sort();
                resultList.Reverse();
                Console.WriteLine(string.Join(" ", resultList));
            }
            else if( resultList.Count >=5)
            {
                resultList.Sort();
                resultList.Reverse();
                Console.WriteLine($"{resultList[0]} {resultList[1]} {resultList[2]} {resultList[3]} {resultList[4]}");
            }
            
        }
    }
}
