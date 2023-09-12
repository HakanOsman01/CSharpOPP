

namespace Telephony.Models
{
    using Interfaces;
    using Telephony.Exceptions;
    

    public class StationaryPhone : IStationeryPhone
    {
        public StationaryPhone()
        {
            
        }
        public string Call(string phoneNumber)
        {
           if(!this.ValidatePhoneNumber(phoneNumber))
           {
                throw new InvalidPhoneNumberException();
           }
            return $"Dialing... {phoneNumber}";

        }
        private bool ValidatePhoneNumber(string phoneNumber) 
            => phoneNumber.All(ch=>char.IsDigit(ch));
       
    }
}
