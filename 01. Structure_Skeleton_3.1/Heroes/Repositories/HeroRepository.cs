using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {
        private List<IHero> models;
        public HeroRepository()
        {
            this.models= new List<IHero>();
        }
        public IReadOnlyCollection<IHero> Models => models.AsReadOnly();

        public void Add(IHero model)
        {
            this.models.Add(model);
        }

        public IHero FindByName(string name) 
         => this.models.FirstOrDefault(m => m.Name == name);

        public bool Remove(IHero model)
        {
            bool result = this.models.Remove(FindByName(model.Name));
            return result;
        }
    }
}
