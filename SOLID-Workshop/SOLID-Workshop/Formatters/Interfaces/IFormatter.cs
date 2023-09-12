



namespace SOLID_Workshop.Formatters.Interfaces
{
    using Layouts.Interfaces;
    using Messages.Interfaces;
    public interface IFormatter
    {
        string FormatMessage(IMessage message,ILayaout layaout);
    }
}
