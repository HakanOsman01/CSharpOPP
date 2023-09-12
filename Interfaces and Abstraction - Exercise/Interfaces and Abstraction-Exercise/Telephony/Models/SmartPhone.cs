


namespace Telephony.Models
{
    using System;
    using Interfaces;
    using Telephony.Exceptions;

    public class SmartPhone : ISmartPhone
    {
        public SmartPhone()
        {
            
        }
        public string BrowseURL(string url)
        {
            if (!this.ValidateURL(url))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";


        }

        public string Call(string phoneNumber)
        {
            if (!this.ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
        private bool ValidatePhoneNumber(string phoneNumber)
           => phoneNumber.All(ch => char.IsDigit(ch));
        private bool ValidateURL(string url)=>url.All(ch=>!char.IsDigit(ch));
    }
}
