

namespace SOLID_Workshop.Exceptions
{
    public class InvalidDateTimeException : Exception
    {
        private const string DefaultMessage = "Provide LogTime was not " +
            "in the correct format!!!";
        public InvalidDateTimeException()
            :base(DefaultMessage)
        {
            
        }
    }
}
