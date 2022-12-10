using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            while(input != "END")
            {
                if(input == "green")
                {
                    int green = greenLight;
                    int free = freeWindow;
                    while(cars.Count > 0)
                    {
                        string currentCar = cars.Peek();
                        if(green >= currentCar.Length)
                        {
                            green -= currentCar.Length;
                            cars.Dequeue();
                            passedCars++;
                        }
                        else if(green <= 0)
                        {
                            break;
                        }
                        else if(green < currentCar.Length)
                        {
                            if(green + free >= currentCar.Length)
                            {
                                green = 0;
                                free -= currentCar.Length;
                                cars.Dequeue();
                                passedCars++;
                            }
                            else if(green + free >= 0 && green + free < currentCar.Length)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar[green+free]}.");
                                return;
                            }
                        }
                      
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
