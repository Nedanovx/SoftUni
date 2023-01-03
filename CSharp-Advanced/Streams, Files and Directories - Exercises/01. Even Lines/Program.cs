namespace EvenLines 
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines 
    { 
        static void Main() 
        {
            string inputFilePath = @"..\..\..\text.txt"; 
            Console.WriteLine(ProcessLines(inputFilePath)); 
        } 
        public static string ProcessLines(string inputFilePath) 
        { 
            StringBuilder sb = new StringBuilder();
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                int count = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(count % 2 == 0)
                    {
                        string replacedSymbol = ReplaceSymbols(line);
                        string reverseWords = ReverseWords(replacedSymbol);
                        sb.AppendLine(reverseWords);
                    }
                    count++;
                }
            }
            return sb.ToString().TrimEnd();
        }

        private static string ReverseWords(string replacedSymbol)
        {
            string[] reversedWord = replacedSymbol.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            return string.Join(" ", reversedWord);
        }

        private static string ReplaceSymbols(string line)
        {
            string[] symbol = { "-", ",", ".", "!", "?" };
            foreach (var item in symbol)
            {
                line = line.Replace(item, "@");
            }
            return line;
        }
    } 
}
