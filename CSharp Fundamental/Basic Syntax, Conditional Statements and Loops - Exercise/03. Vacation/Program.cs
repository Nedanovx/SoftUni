using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Friday Saturday Sunday

            // Students     8.45     9.80    10.46

            //Business       10.90   15.60      16

            //Regular       15         20       22.50
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            sum = countOfPeople * 8.45;
                            if (countOfPeople >= 30)
                            {
                                sum *= 0.85;
                            }
                            break;
                        case "Saturday":
                            sum = countOfPeople * 9.80;
                            if (countOfPeople >= 30)
                            {
                                sum *= 0.85;
                            }
                            break;
                        case "Sunday":
                            sum = countOfPeople * 10.46;
                            if (countOfPeople >= 30)
                            {
                                sum *= 0.85;
                            }
                            break;
                    }
                    
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            sum = countOfPeople * 10.9;
                            if (countOfPeople >= 100)
                            {
                                sum -= sum / countOfPeople * 10;
                            }
                            break;
                        case "Saturday":
                            sum = countOfPeople * 15.6;
                            if (countOfPeople >= 100)
                            {
                                sum -= sum / countOfPeople * 10;
                            }
                            break;
                        case "Sunday":
                            sum = countOfPeople * 16;
                            if (countOfPeople >= 100)
                            {
                                sum -= sum / countOfPeople * 10;
                            }
                            break;
                    }
                    
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            sum = countOfPeople * 15;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                sum *= 0.95;
                            }
                            break;
                        case "Saturday":
                            sum = countOfPeople * 20;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                sum *= 0.95;
                            }
                            break;
                        case "Sunday":
                            sum = countOfPeople * 22.50;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                sum *= 0.95;
                            }
                            break;
                    }
                    break;
                    
                    
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
