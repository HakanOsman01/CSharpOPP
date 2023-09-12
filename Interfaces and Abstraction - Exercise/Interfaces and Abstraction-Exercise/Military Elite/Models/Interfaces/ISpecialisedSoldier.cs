



namespace Military_Elite.Models.Interfaces
{
    using Enums;
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
