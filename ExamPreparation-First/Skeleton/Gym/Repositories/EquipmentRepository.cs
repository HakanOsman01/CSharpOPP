
using Gym.Models.Equipment;
using Gym.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<Equipment>
    {
        private List<Equipment> models;
        public EquipmentRepository()
        {
            models= new List<Equipment>();
        }
        public IReadOnlyCollection<Equipment> Models { get { return models.AsReadOnly(); } }

        public void Add(Equipment model)
        {
            models.Add(model);
        }

        public Equipment FindByType(string type)
        {
           return models.FirstOrDefault(e=>e.GetType().Name == type);
        }

        public bool Remove(Equipment model)
        {
           return models.Remove(model);
        }
    }
}
