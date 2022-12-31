using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            while (input != "end of contests")
            {
                string[] inputArg = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = inputArg[0];
                string password = inputArg[1];
                if (!contestAndPassword.ContainsKey(contest))
                {
                    contestAndPassword.Add(contest, password);
                }
                input = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            string examInfo = Console.ReadLine();
            while (examInfo != "end of submissions")
            {
                string[] examInfoArg = examInfo.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string exam = examInfoArg[0];
                string pass = examInfoArg[1];
                string username = examInfoArg[2];
                int points = int.Parse(examInfoArg[3]);
                if (contestAndPassword.ContainsKey(exam) && contestAndPassword[exam] == pass)
                {
                    if (!candidates.ContainsKey(username))
                    {
                        candidates.Add(username, new Dictionary<string, int>());
                    }
                    if (!candidates[username].ContainsKey(exam))
                    {
                        candidates[username][exam] = points;
                    }
                    if (candidates[username][exam] < points)
                    {
                        candidates[username][exam] = points;
                    }
                }
                examInfo = Console.ReadLine();
            }
            string bestCandidate = candidates.OrderByDescending(x => x.Value.Values.Sum()).First().Key;
            int bestCandidatePoint = candidates[bestCandidate].Values.Sum();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatePoint} points.");
            Console.WriteLine("Ranking:");
            foreach(var name in candidates.OrderBy(x=>x.Key))
            {
                Console.WriteLine(name.Key);
                foreach(var kvp in name.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
