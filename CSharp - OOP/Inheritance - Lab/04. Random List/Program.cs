using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Hi");
            list.Add(",");
            list.Add("how");
            list.Add("are");
            list.Add("you");
            list.Add("?");
            Console.WriteLine(list.RandomString());
        }
    }
}
