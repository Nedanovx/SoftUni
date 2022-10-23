using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientType = Console.ReadLine();
            decimal total = 0m;
            bool isItPrice = true;
            while (isItPrice)
            {
                if (clientType == "special" || clientType == "regular")
                {
                    isItPrice = false;
                    break;
                }


                decimal price = decimal.Parse(clientType);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");

                }
                else if (price == 0)
                {
                    Console.WriteLine("Invalid order!");

                }
                else
                {
                    total += price;
                }

                clientType = Console.ReadLine();


            }
            if (clientType == "special" && total > 0)
            {
                decimal totalPrice = total * 1.2m;
                decimal taxes = totalPrice - total;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPrice * 0.9m):f2}$");

            }
            else if (clientType == "regular" && total > 0)
            {
                decimal totalPrice = total * 1.2m;
                decimal taxes = totalPrice - total;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPrice):f2}$");

            }
            else
            {
                Console.WriteLine("Invalid order!");
            }

        }
    }
}