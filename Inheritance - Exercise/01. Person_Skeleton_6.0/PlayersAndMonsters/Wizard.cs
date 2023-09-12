using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Wizard : Hero
    {
        public Wizard(string username,int level, int mana) : base(username, level)
        {

            this.Mana = mana;

        }
        public int Mana { get; set; }
    }
}
