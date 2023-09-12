
using _03._Raiding.Enums;

namespace _03._Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name, HeroType type)
            : base(name, type)
        {
        }

        public override string CastAbility()
        {
            return $"{typeof(Paladin).Name} - {this.Name} healed for {this.Power}";
        }
    }
}
