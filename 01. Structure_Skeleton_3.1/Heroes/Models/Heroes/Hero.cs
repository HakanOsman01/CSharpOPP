using Heroes.Models.Contracts;
using Heroes.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;
        public Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour=armour;
        }
        public string Name
        {
            get=> name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.HeroNameNull);
                }
                name=value;
            }
        }

        public int Health
        {
            get=>health;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.HeroHealthBelowZero);
                }
                health=value;
            }
        }

        public int Armour
        {
            get => armour;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.HeroArmourBelowZero);
                }
                armour = value;
            }
        }

        public IWeapon Weapon
        {
            get=> weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.WeaponNull);
                }
                weapon = value;
            }
        }

        public bool IsAlive => this.Health > 0;

        public void AddWeapon(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void TakeDamage(int points)
        {
            if (this.Armour - points < 0)
            {
                int diffrence = this.Armour - points;
                this.Armour = 0;
                if (this.Health - Math.Abs(diffrence) < 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health-= Math.Abs(diffrence);
                }
                

            }
            else
            {
                this.Armour -= points;
            }
          
        }
    }
}
