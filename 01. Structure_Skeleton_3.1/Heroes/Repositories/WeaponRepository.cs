using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> models;
        public WeaponRepository()
        {
            this.models = new List<IWeapon>();
        }
      
        public IReadOnlyCollection<IWeapon> Models => this.models.AsReadOnly();

        public void Add(IWeapon model)
        {
            this.models.Add(model);
        }

        public IWeapon FindByName(string name) => this.models.FirstOrDefault(m => m.Name == name);
        public bool Remove(IWeapon model)
        {
            bool result = this.models.Remove(FindByName(model.Name));
            return result;
        }
    }
}
