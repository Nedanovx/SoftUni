using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            if(!ValidateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidateUrl(string url)
        =>url.All(x=> !char.IsDigit(x));

        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException($"Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        => phoneNumber.All(x => Char.IsDigit(x));
    }
}
