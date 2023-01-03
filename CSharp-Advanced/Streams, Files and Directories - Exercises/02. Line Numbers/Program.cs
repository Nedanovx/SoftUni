namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);
        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] line = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < line.Length; i++)
            {
                int letterCount = line[i].Count(c => char.IsLetter(c));
                int punctuationCount = line[i].Count(x => char.IsPunctuation(x));
                sb.AppendLine($"Line {i + 1}. {line} ({letterCount})({punctuationCount})");
            }  
            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}