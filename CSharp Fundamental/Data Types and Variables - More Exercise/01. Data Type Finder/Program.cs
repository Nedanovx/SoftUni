using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    bool isInt = int.TryParse(command, out int i);
                    bool isFloat = double.TryParse(command, out double d);
                    bool isChar = char.TryParse(command, out char c);
                    bool isBool = bool.TryParse(command, out bool b);
                    if (isInt)
                    {
                        Console.WriteLine($"{command} is integer type");
                    }
                    else if (isFloat)
                    {
                        Console.WriteLine($"{command} is floating point type");
                    }
                    else if (isChar)
                    {
                        Console.WriteLine($"{command} is character type");
                    }
                    else if (isBool)
                    {
                        Console.WriteLine($"{command} is boolean type");
                    }
                    else
                    {
                        Console.WriteLine($"{command} is string type");
                    }
                }
            }
        }
    }
}