

using _03._Raiding.Enums;

namespace _03._Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name,HeroType type) 
            : base(name, type)
        {
        }

        public override string CastAbility()
        {
            return $"{typeof(Warrior).Name} - {this.Name} healed for {this.Power}";
        }
    }
}
