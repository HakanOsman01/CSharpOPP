using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
           List<IHero>barbarians=players.Where(p=>p.GetType().Name== "Barbarian")
                .ToList();
            List<IHero>knights= players.Where(p => p.GetType().Name == "Knight")
                .ToList();
            bool isKnightsWin = false;
            bool isBarbariansWin = false;
            while (true)
            {
               
                for (int i = 0; i < knights.Count; i++)
                {
                    foreach (IHero currentBarbarin in barbarians)
                    {
                        if (currentBarbarin.IsAlive && knights[i].IsAlive 
                            && knights[i].Weapon.Durability>0)
                        {
                            currentBarbarin.TakeDamage(knights[i].Weapon.DoDamage());
                        }
                       
                    }
                }
                if (!barbarians.Any(b => b.IsAlive))
                {
                    isKnightsWin = true;
                    break;
                }
                for (int i = 0; i < barbarians.Count; i++)
                {
                    foreach (IHero currentKnight in knights)
                    {
                        if (currentKnight.IsAlive && barbarians[i].IsAlive &&
                            barbarians[i].Weapon.Durability>0)
                        {
                            currentKnight.TakeDamage(barbarians[i].Weapon.DoDamage());
                        }
                        
                    }
                }
                if (!knights.Any(k => k.IsAlive))
                {
                    isBarbariansWin = true;
                    break;
                }

            }
            if (isKnightsWin)
            {
                return $"The knights took {knights.Where(k=>!k.IsAlive).Count()} " +
                    $"casualties but won the battle.";
            }
          
               return $"The barbarians took {barbarians.Where(b => !b.IsAlive).Count()} " +
                    $"casualties but won the battle.";
            
           
        }
    }
}
