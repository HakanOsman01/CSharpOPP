

namespace Military_Elite.Models.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission>Missions { get; }
    }

}
