using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Elf: Hero
    {
        public Elf(string username,int level, int arrows) : base(username, level)
        {

            this.Arrows = arrows;

        }
        public int Arrows { get; set; }
    }
}
