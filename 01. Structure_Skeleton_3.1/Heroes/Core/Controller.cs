using Heroes.Core.Contracts;
using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using Heroes.Models.Map;
using Heroes.Models.Weapons;
using Heroes.Repositories;
using Heroes.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Core
{
    public class Controller : IController
    {
        private HeroRepository heroes;
        private WeaponRepository weapons;
        public Controller()
        {
            heroes = new HeroRepository();
            weapons = new WeaponRepository();
        }
        public string AddWeaponToHero(string weaponName, string heroName)
        {
            IHero hero = this.heroes.FindByName(heroName);
            IWeapon weapon = this.weapons.FindByName(weaponName);
            if (hero == null)
            {
                throw new InvalidOperationException
                 (string.Format(OutputMessages.HeroDoesNotExist, heroName));
            }
            if (weapon==null)
            {
                throw new InvalidOperationException
                 (string.Format(OutputMessages.WeaponDoesNotExist, weaponName));
            }
            
            if (hero.Weapon != null)
            {
                throw new 
                 InvalidOperationException
                 (string.Format(OutputMessages.HeroAlreadyHasWeapon, heroName));
            }
            hero.AddWeapon(weapon);
            this.weapons.Remove(weapon);
            return string.Format(OutputMessages.WeaponAddedToHero, 
                heroName, weaponName.ToLower());
        }

        public string CreateHero(string type, string name, int health, int armour)
        {
            IHero hero = this.heroes.FindByName(name);
            if(hero != null)
            {
                throw new InvalidOperationException
                  (string.Format(OutputMessages.HeroAlreadyExist, name));
            }
            if(type!= "Barbarian" && type!= "Knight")
            {
                throw new InvalidOperationException(string.Format(OutputMessages.HeroTypeIsInvalid));
            }

            IHero typeHero = null;
            if(type=="Knight")
            {
                typeHero=new Knight(name,health,armour);

                this.heroes.Add(typeHero);
                return string.Format("Successfully added Sir {0} to the collection.", name);
            }
            typeHero = new Barbarian(name, health, armour);
            this.heroes.Add(typeHero);
            return string.Format("Successfully added Barbarian {0} to the collection.", name);
        }

        public string CreateWeapon(string type, string name, int durability)
        {
            IWeapon weapon = this.weapons.FindByName(name);
            if (weapon != null)
            {
                throw new InvalidOperationException
                    (string.Format(OutputMessages.WeaponAlreadyExists, name));
            }
            
            if(type!= "Mace" && type!= "Claymore")
            {
                throw new InvalidOperationException(string.Format(OutputMessages.WeaponTypeIsInvalid));
            }
            IWeapon createWeapon = null;
            if (type == "Mace")
            {
                createWeapon = new Mace(name, durability);
            }
            else
            {
                createWeapon = new Claymore(name, durability);
            }
            this.weapons.Add(createWeapon);
            return string.Format(OutputMessages.WeaponAddedSuccessfully, type.ToLower(), name);
        }

        public string HeroReport()
        {
            IReadOnlyList<IHero> herosReport = (IReadOnlyList<IHero>)
                this.heroes.Models;
            herosReport=herosReport
                .OrderBy(h=>h.GetType().Name)
                .ThenByDescending(h=>h.Health)
                .ThenBy(h=> h.Name)
                .ToList();

            StringBuilder sb=new StringBuilder();
            foreach (IHero hero in herosReport)
            {
                sb.AppendLine($"{hero.GetType().Name}: { hero.Name}");
                sb.AppendLine($"--Health: {hero.Health}");
                sb.AppendLine($"--Armour: {hero.Armour}");
                string weaponName = hero.Weapon != null ? hero.Weapon.Name 
                    : "Unarmed";
                sb.AppendLine($"--Weapon: {weaponName}");

            }
            return sb.ToString().TrimEnd();
        }

        public string StartBattle()
        {
            IReadOnlyList<IHero> aliveAndWeaponsHeroes = (IReadOnlyList<IHero>)
            this.heroes.Models;
            aliveAndWeaponsHeroes = aliveAndWeaponsHeroes
                .Where(h => h.IsAlive && h.Weapon != null)
                .ToList();
            Map map=new Map();
           string result= map.Fight((ICollection<IHero>)aliveAndWeaponsHeroes);
            return result;

        }
    }
}
