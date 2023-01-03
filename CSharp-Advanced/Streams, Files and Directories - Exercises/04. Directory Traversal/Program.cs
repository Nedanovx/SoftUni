namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var extension in extensionsFiles.OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine(extension.Key);
                var orderedFiles = extension.Value.OrderByDescending(x=>x.Length);
                foreach(var file in orderedFiles)
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length/1024:f3}kb");
                }
            }
            return sb.ToString();
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filepath, textContent);
        }
    }
}