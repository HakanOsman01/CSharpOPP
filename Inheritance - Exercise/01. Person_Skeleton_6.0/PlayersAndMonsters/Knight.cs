using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string username,int level, int stamina) : base(username, level)
        {

           this.Stamina = stamina;

        }
        public int Stamina { get; set; }
    }
}
