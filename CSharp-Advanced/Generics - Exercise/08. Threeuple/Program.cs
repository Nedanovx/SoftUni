using System;
namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string city = personInfo[3];
            if(personInfo.Length >= 4)
            {
                city = $"{personInfo[3]} {personInfo[4]}";
            }
            MyThreeuple<string, string, string> person = new MyThreeuple<string, string, string>($"{personInfo[0]} {personInfo[1]}", personInfo[2], city);

            string[] beerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            bool drunk = beerInfo[2] == "drunk";          

            MyThreeuple<string, int, bool> beer = new MyThreeuple<string, int, bool>(beerInfo[0], int.Parse(beerInfo[1]),drunk);

            string[] bankInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            MyThreeuple<string, double, string> bank = new MyThreeuple<string, double, string>(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(bank);
        }
    }
}
