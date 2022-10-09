using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLengthValid = IsPasswordLengthValid(password);
            bool isPasswordAlphaNumeric = IsPasswordAlphaNumeric(password);
            bool isPasswordHasTwoDigits = IsPasswordContaingAtLeastTwoDigits(password);
            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordHasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordHasTwoDigits && isPasswordAlphaNumeric && isLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid (string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric (string password)
        {
           foreach(char letter in password)
            {
                if (! Char.IsLetterOrDigit (letter))
                {
                    return false;
                }
            }   
           return true;
        }
        static bool IsPasswordContaingAtLeastTwoDigits (string password)
        {
            int digitsCount = 0;
            foreach (char letter in password)
            {
                if (Char.IsDigit (letter))
                    digitsCount++;
            }
            return digitsCount >= 2;
        }
    }
}
