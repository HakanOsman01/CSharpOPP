


namespace SOLID_Workshop.Messages
{
    using Enums;
    using Interfaces;
    using SOLID_Workshop.Exceptions;

    public class Message : IMessage
    {
        private const string EmptyLogTimeMessage = "Argument cannot be empty string or null";
        private string messageText;
        private string logTime;
        public Message(string logTime,string messageText,ReportLevel level)
        {
            this.LogTime = logTime;
            this.messageText = messageText;
            this.Level = level;
        }
        public string LogTime
        {
            get
            {
                return logTime;
            }
            private set
            {
                if (!IsValidDateTime(value))
                {
                    throw new InvalidDateTimeException();
                }
                else if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.LogTime), EmptyLogTimeMessage);
                }
                this.logTime = value;
            }
        }

        public string MessageText
        {
            get
            {
                return this.messageText;
            }
            private set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(this.MessageText),EmptyLogTimeMessage);
                }
                this.messageText= value;
            }
        }

        public ReportLevel Level { get; }
        private bool IsValidDateTime(string text)
            =>DateTime.TryParse(text, out DateTime dateTime);
       
    }
}
