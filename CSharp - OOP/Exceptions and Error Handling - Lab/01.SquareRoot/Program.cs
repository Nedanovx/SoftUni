namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                throw new ArgumentException("Invalid number.");
                }
                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}