using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Models.Contracts
{
    public interface ICar
    {
        void Accselarate(int speed);
        string Model { get; }
        int HorsePower { get; }

        

    }
}
