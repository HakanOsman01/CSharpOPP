
namespace _03._Raiding.Core
{
    using Enums;
    using Models;
    using Interfaces;
    using _03._Raiding.Models.Interfaces;

    public class Engine : IEngine
    {
        public void Run()
        {
            int n=int.Parse(Console.ReadLine());
            
            List<BaseHero>heroes = new List<BaseHero>();
            for (int cur=1; cur<=n; cur++)
            {
                string name=Console.ReadLine();
                string heroType=Console.ReadLine();
                if(!Enum.IsDefined(typeof(HeroType), heroType))
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                BaseHero baseHero = null;
                switch (heroType)
                {
                    case "Druid":
                        baseHero = new Druid(name,HeroType.Druid);
                        break;
                    case "Paladin":
                        baseHero=new Paladin(name,HeroType.Paladin);
                        break;
                    case "Rogue":
                        baseHero=new Rogue(name,HeroType.Rogue);
                        break;
                    case "Warrior":
                        baseHero=new Warrior(name,HeroType.Warrior);
                        break;
                }
                heroes.Add(baseHero);
                


            }
            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = CastPowers(heroes);
            if (bossPower > totalPower)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }

        }
        private int CastPowers(List<BaseHero> heroes)
        {
            int totalPower = 0;
            foreach (var currentHero in heroes)
            {
                Console.WriteLine(currentHero.CastAbility());

                totalPower += currentHero.Power;

            }
            return totalPower;
        }
     
        
    }
}
