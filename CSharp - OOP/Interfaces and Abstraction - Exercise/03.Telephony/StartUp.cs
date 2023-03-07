using System.Numerics;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls =  Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ICallable phone;
            foreach (string phoneNumber in phoneNumbers)
            {
                
                if (phoneNumber.Length == 10)
                {
                     phone = new Smartphone();                   
                }
                else
                {
                     phone = new StationaryPhone();                  
                }
                try
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            IBrowsable browsablePhone = new Smartphone();
            foreach (string url in urls)
            {
                
                try
                {
                    Console.WriteLine(browsablePhone.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}