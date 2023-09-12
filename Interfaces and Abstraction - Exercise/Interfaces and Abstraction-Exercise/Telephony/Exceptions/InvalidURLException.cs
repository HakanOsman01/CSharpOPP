

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string InvalidURLMessage = "Invalid URL!";
        public InvalidURLException()
            : base(InvalidURLMessage)
        {

        }
        public InvalidURLException(string url)
            : base(url) 
        {
            
        }
    }
}
