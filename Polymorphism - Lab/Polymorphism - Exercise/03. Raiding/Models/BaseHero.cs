


namespace _03._Raiding.Models
{
    using _03._Raiding.Enums;
    using Interfaces;
    public abstract class BaseHero : IPowerable
    {
        protected BaseHero(string name,HeroType type)
        {
            this.Name = name;
            this.Power = (int)type;
        }
        public int Power { get;private set; }
        public string Name { get; private set; }
        public abstract string CastAbility();
     


    }
}
