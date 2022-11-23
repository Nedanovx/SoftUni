using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfParticipans = Console.ReadLine();
            string[] participants = nameOfParticipans.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> racer = new Dictionary<string, int>();
            foreach (string participant in participants)
            {
                racer.Add(participant, 0);
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string patternName = @"(?<name>[A-Za-z])";
                string kilometers = @"(?<km>[0-9])";
                Regex regex = new Regex(patternName);
                MatchCollection matchName = regex.Matches(input);
                Regex regexKm = new Regex(kilometers);
                MatchCollection matchKm = regexKm.Matches(input);
                string name = string.Empty;
                int distance = 0;
                foreach (var i in matchName)
                {
                    name += i;
                }

                foreach (var i in matchKm)
                {
                    distance += int.Parse(i.ToString());
                }
                for (int i = 0; i < participants.Length; i++)
                {
                    if (name == participants[i])
                    {
                        if (racer.ContainsKey(name))
                        {
                            racer[name] += distance;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }

                input = Console.ReadLine();
            }
            int count = 1;
            var orderedParticipants = racer.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);
            List<string> finalThreePlaces = new List<string>(orderedParticipants.Keys);
            foreach (var kvp in racer.OrderByDescending(x => x.Value))
            {
               
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if(count == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if(count == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                    break;
                }
                count++;
            }

        }
    }
}
