

namespace Telephony.Models.Interfaces
{
    public interface ISmartPhone : IStationeryPhone
    {
        string BrowseURL(string url);
    }
}
