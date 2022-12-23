using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while(command != "PARTY")
            {
                for (int j = 0; j <= command.Length - 8; j++)
                {
                    char firstSymbol = command[j];
                    if (char.IsDigit(firstSymbol))
                    {
                        vip.Add(command);
                    }
                    else if (char.IsLetter(firstSymbol))
                    {
                        regular.Add(command);
                    }
                }
                command = Console.ReadLine();
            }
            string reservation = Console.ReadLine();
            while (reservation != "END")
            {
                for (int j = 0; j <= reservation.Length - 8; j++)
                {
                    char firstSymbol = reservation[j];
                    if (char.IsDigit(firstSymbol))
                    {
                        if (vip.Contains(reservation))
                        {
                            vip.Remove(reservation);
                        }
                    }
                    else if (char.IsLetter(firstSymbol))
                    {
                        if (regular.Contains(reservation))
                        {
                            regular.Remove(reservation);
                        }
                    }
                }
                reservation = Console.ReadLine();
            }
            Console.WriteLine($"{vip.Count + regular.Count}");
            foreach (string vipReservation in vip)
            {
                Console.WriteLine(vipReservation);
            }
            foreach (string regularReservation in regular)
            {
                Console.WriteLine(regularReservation);
            }

        }      
    }
}
