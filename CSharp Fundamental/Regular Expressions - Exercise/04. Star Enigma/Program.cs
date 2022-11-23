using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\@\-\!\:\>]*?\@(?<planetName>[A-Za-z]+)[^\@\-\!\:\>]*?:(?<population>\d+)[^\@\-\!\:\>]*?\![^\@\-\!\:\>]*?(?<attack>A|D)\![^\@\-\!\:\>]*?\-\>(?<army>\d+)[^\@\-\!\:\>]*";
            Regex regex = new Regex(pattern);
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();
            int number = int.Parse(Console.ReadLine());
            for(int i= 0; i < number; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptedMessage(encryptedMessage);
                
                Match match = regex.Match(decryptedMessage);
                if(match.Success)
                {
                    string planetName = match.Groups["planetName"].Value;
                    string attack = match.Groups["attack"].Value;
                    if(attack == "A")
                    {
                        attackedPlanet.Add(planetName);
                    }
                    else if(attack == "D")
                    {
                        destroyedPlanet.Add(planetName);
                    }
                }
            }
            PrintPlanets(attackedPlanet, "Attacked");
            PrintPlanets(destroyedPlanet, "Destroyed");

        }
        static string DecryptedMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionStep = GetDecryptedMessage(encryptedMessage);
            foreach(char symbol in encryptedMessage)
            {
                decryptedMessage.Append((char)(symbol-decryptionStep));
            }
            return decryptedMessage.ToString();
        }

         static int GetDecryptedMessage(string encryptedMessage)
        {
            int decryptionStep = 0;
            foreach(char symbol in encryptedMessage.ToLower())
            {
                if(symbol == 'a' || symbol =='s' || symbol == 't' || symbol == 'r')
                {
                    decryptionStep++;
                }
            }
            return decryptionStep;
        }
        static void PrintPlanets(List<string> planets, string attack)
        {
            Console.WriteLine($"{attack} planets: {planets.Count}");
            foreach (string planet in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");

            }
        }
    }
}
