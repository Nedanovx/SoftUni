using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchesCollection = regex.Matches(input);
            string[] result = matchesCollection.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
