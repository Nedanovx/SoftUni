using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> output = new List<string>();
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    string firstLine = reader1.ReadLine();
                    string secondLine = reader2.ReadLine();
                    while (firstLine != null || secondLine != null)
                    {
                        
                        if(firstLine != null && secondLine == null)
                        {
                            output.Add(firstLine);
                            output.Add((string)reader1.ReadToEnd());
                            break;
                        }
                        else if(firstLine == null && secondLine != null)
                        {
                            output.Add(secondLine);
                            output.Add((string)reader2.ReadToEnd());
                            break;
                        }
                        output.Add(firstLine);
                        output.Add(secondLine);
                        firstLine = reader1.ReadLine();
                        secondLine = reader2.ReadLine();
                    }                   
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in output)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
