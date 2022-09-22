using System;


namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pass = string.Empty;
            
            int count = 0;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pass += userName[i];
            }
            string password;
            while ((password = Console.ReadLine()) != pass)
            {
                count++;
                if (count >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }

                Console.WriteLine($"User {userName} logged in.");

        }
    } 
}
