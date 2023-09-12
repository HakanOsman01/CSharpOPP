
using SOLID_Workshop.Appenders.Interfaces;
using SOLID_Workshop.Layouts.Interfaces;
using SOLID_Workshop.Messages;
using SOLID_Workshop.Messages.Interfaces;

namespace Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ConsoleAppender() 
        {
            this.Count = 0;
        }

        public ConsoleAppender(ILayaout layaout)
            :this()
        {
            this.Layaout = layaout;
        }
        public int Count { get; private set; }

        public ILayaout Layaout { get; set; }

        public void Append(IMessage message)
        {
           string formatMessage=this.FormatMessage(message);
            Console.WriteLine(formatMessage);
            this.Count++;
        }
       private string FormatMessage(IMessage message) =>
             String.Format(this.Layaout.Format, message.LogTime,
                message.Level.ToString(), message.MessageText);


    }
}
