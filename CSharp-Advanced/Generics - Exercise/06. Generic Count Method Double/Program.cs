using System;

namespace GenericCountMethodDouble
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            {
                for (int i = 0; i < numberOfInput; i++)
                {
                    box.Items.Add(double.Parse(Console.ReadLine()));
                }
            }
            double comparingItem = double.Parse(Console.ReadLine());
            int result = box.ComparisonMethod(comparingItem);
            Console.WriteLine(result);
        }
    }
}
