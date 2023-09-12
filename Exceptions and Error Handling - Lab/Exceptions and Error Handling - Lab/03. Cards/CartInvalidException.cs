

namespace _03._Cards
{
    public class CartInvalidException : Exception
    {
        private const string INVALID_MESSAGE = "Invalid card!";
        public CartInvalidException()
            :base(INVALID_MESSAGE) 
        {
            
        }
    }
}
