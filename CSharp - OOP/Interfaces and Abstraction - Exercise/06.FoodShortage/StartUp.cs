using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System.Linq;
using System.Security.Principal;

namespace FoodShortage

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for(int i = 0; i < numberOfInput; i++)
            {
                string[] buyerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(buyerInfo.Length == 3)
                {
                    IBuyer rebel = new Rebel(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2]);
                    buyers.Add(rebel);
                }
                else
                {
                    IBuyer citizen = new Citizens(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2], buyerInfo[3]);
                    buyers.Add(citizen);
                }
            }
            string input = Console.ReadLine();
            while(input != "End")
            {
                foreach (var buyer in buyers.Where(x => x.Name == input))
                {
                    buyer.BuyFood();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(buyers.Sum(x=>x.Food));
            
        }
    }
}