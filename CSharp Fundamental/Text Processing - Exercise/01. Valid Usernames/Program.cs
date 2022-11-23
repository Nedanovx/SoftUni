using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] username =Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach(string name in username)
            {
                if(name.Length >= 3 && name.Length <= 16)
                {
                    bool isUsernameValid = true;
                    foreach(char symbol in name)
                    {
                        if(!(char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if(isUsernameValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
