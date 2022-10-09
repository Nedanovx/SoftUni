using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            int vowelsCount = CountVowel(text);
            Console.WriteLine(vowelsCount);
        }
        static int CountVowel (string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
