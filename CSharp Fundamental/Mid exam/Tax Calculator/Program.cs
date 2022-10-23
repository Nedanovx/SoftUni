using System;
using System.Linq;

namespace Tax_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>").ToArray();
            double sumTax = 0;
            for(int i = 0; i < vehicles.Length; i++)
            {
                string[] carInfo = vehicles[i].Split(" ").ToArray();
                if (carInfo[0] == "family")
                {
                    double tax = 50;
                    tax -= 5* int.Parse(carInfo[1]);
                    int km = int.Parse(carInfo[2]) / 3000;
                    tax += 12 * km;
                    Console.WriteLine($"A {carInfo[0]} car will pay {tax:f2} euros in taxes.");
                    sumTax+= tax;
                }
                else if (carInfo[0] == "heavyDuty")
                {
                    double tax = 80;
                    tax -= 8 * int.Parse(carInfo[1]);
                    int km = int.Parse(carInfo[2]) / 9000;
                    tax += 14 * km;
                    Console.WriteLine($"A {carInfo[0]} car will pay {tax:f2} euros in taxes.");
                    sumTax += tax;
                }
                else if(carInfo[0] == "sports")
                {
                    double tax = 100;
                    tax -= 9 * int.Parse(carInfo[1]);
                    int km = int.Parse(carInfo[2]) / 2000;
                    tax += 18 * km;
                    Console.WriteLine($"A {carInfo[0]} car will pay {tax:f2} euros in taxes.");
                    sumTax += tax;
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
                
            }
            Console.WriteLine($"The National Revenue Agency will collect {sumTax:f2} euros in taxes.");
        }
    }
}
