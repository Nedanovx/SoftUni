using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                FileInfo currentFile = new FileInfo(file);
                sum += currentFile.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText(outputFilePath, sum.ToString());
        }

    }  
}
