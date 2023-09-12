﻿

namespace Military_Elite.Models.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair>Repairs { get; }
    }
}
