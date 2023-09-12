using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotService.Repositories
{
    public class SupplementRepository : IRepository<ISupplement>
    {
        private readonly List<ISupplement> supplements;
        public void AddNew(ISupplement model)
        {
             supplements.Add(model);
        }

        public ISupplement FindByStandard(int interfaceStandard)
        {
            if (this.supplements.Any(s => s.InterfaceStandard == interfaceStandard))
            {
                return this.supplements.FirstOrDefault(s=>s.InterfaceStandard==interfaceStandard);
            }
            else
            {
                return null;
            }
           
        }

        public IReadOnlyCollection<ISupplement> Models()
        {
            return supplements.AsReadOnly();
        }

        public bool RemoveByName(string typeName)
        {
            
           return this.supplements
                .Remove(this.supplements.FirstOrDefault(x => x.GetType().Name == typeName));

        }
    }
}
