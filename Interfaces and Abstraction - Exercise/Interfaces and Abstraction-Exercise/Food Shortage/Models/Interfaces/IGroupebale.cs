using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Shortage.Models.Interfaces
{
    public interface IGroupebale : IBuyer
    {
        string Group { get; }
    }
}
