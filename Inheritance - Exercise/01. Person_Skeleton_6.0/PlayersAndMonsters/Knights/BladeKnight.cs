using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters.Knights
{
    public class BladeKnight : DarkKnight
    {
        private const int DefaultStamina = 300;
        public BladeKnight(string username, int level) : base(username, level,DefaultStamina)
        {

        }
    }
}
