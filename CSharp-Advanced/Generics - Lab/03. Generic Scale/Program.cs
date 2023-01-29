using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(5, 9);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
