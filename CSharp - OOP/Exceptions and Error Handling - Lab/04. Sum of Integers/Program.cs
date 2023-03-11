namespace _04._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string[] elements = Console.ReadLine().Split(" ");
            for (int i = 0; i < elements.Length; i++)
            {
                int currentElement;
                try
                {
                    currentElement = int.Parse(elements[i]);
                    list.Add(currentElement);  
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is in wrong format!");                   
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is out of range!");                   
                }
                finally
                {
                    Console.WriteLine($"Element '{elements[i]}' processed - current sum: {list.Sum()}");
                }


            }
            Console.WriteLine($"The total sum of all integers is: {list.Sum()}");
        }
    }
}