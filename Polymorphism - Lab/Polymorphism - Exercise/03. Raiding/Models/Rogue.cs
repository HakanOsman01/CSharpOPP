

using _03._Raiding.Enums;

namespace _03._Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name,HeroType type) 
            : base(name, type)
        {
        }

        public override string CastAbility()
        {
            return $"{typeof(Rogue).Name} - {this.Name} healed for {this.Power}";
        }
    }
}
