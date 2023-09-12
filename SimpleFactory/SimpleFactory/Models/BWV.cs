using SimpleFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Models
{
    public class BWV : ICar
    {
        public BWV(string model, int horsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Model { get; private set; }

        public int HorsePower { get; private set; }

        public void Accselarate(int speed)
        {
            this.HorsePower += speed;
        }
    }
}
