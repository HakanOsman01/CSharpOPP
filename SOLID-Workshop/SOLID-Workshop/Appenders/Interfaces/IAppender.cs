



namespace SOLID_Workshop.Appenders.Interfaces
{
    using Messages.Interfaces;
    using Layouts.Interfaces;

    public interface IAppender
    {
        int Count { get; }
        ILayaout Layaout { get; }

        void Append(IMessage message);
    }
}
