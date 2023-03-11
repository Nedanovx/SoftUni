using System.Linq.Expressions;

namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            ReadNumber(start, end);
        }

        private static void ReadNumber(int start, int end)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input <= start || input >= end)
                    {
                        throw new ArgumentException($"Your number is not in range {start} - 100!");
                    }
                    else
                    {
                        array[i] = input;
                        start = input;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    i--;

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;

                }
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}