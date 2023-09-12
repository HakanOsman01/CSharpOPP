using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class MuseElf:Elf 
    {
        private const int DeafaultArrows = 150;
        public MuseElf(string name,int level):base(name,level,DeafaultArrows)
        {
            
        }
    }
}
