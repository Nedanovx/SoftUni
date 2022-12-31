using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt"; 
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().Split(" ");
                    foreach (string word in words)
                    {
                        if (!output.ContainsKey(word))
                        {
                            output.Add(word.ToLower(), 0);
                        }
                    }
                    using (StreamReader inputText = new StreamReader(textFilePath))
                    {
                        var line = inputText.ReadToEnd();
                        foreach (var currentline in line.Split(new char[] { '.', ',', ' ', '?', '!', '-' }))
                        {
                            string currentWord = currentline.ToLower();
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (currentWord == words[i])
                                {
                                    output[currentWord]++;
                                }
                            }
                        }
                    }
                }
            }
            using(StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach(var kvp in output.OrderByDescending(x=>x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }

        }
    }
}
