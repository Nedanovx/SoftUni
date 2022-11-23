using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string file = input[input.Length - 1];
            string[] splitLastFile = file.Split('.');
            string fileName = splitLastFile[0];
            string extension = splitLastFile[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
