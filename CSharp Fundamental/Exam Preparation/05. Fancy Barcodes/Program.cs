using System;
using System.Text.RegularExpressions;

namespace _05._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            int number = int.Parse(Console.ReadLine());
            Regex barcodeRegex = new Regex(pattern);
            Regex productGroupRegex = new Regex(@"\d+");
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                Match match = barcodeRegex.Match(input);
                if(match.Success)
                {
                    MatchCollection product = productGroupRegex.Matches(match.Value);
                    if(product.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", product)}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
