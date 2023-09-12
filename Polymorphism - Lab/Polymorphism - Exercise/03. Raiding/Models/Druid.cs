

using _03._Raiding.Enums;

namespace _03._Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name,HeroType type) 
            : base(name,type)
        {

        }

        public override string CastAbility()
        {
            return $"{typeof(Druid).Name} - {this.Name} healed for {this.Power}";
        }
    }
}
