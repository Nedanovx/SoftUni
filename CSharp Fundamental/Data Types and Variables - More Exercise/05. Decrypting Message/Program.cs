using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfChar = int.Parse(Console.ReadLine());
            string messges = "";
            for (int i = 0; i < numberOfChar; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int decrypting = 0;
                decrypting = ((int)symbol);
                decrypting += key;
                decrypting = (char)decrypting;
                messges =messges + (char)decrypting; 
            }
            Console.Write(messges);
        }
    }
}
