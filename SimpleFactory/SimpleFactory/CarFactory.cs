using SimpleFactory.Models;
using SimpleFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CarFactory
    {
        private ICar car;
        public ICar CreateCar(string model,int horsePower)
        {
            if (model == "BWV")
            {
                car=new BWV(model, horsePower);
            }
            else if (model == "Audi")
            {
                car=new Audi(model, horsePower);

            }
            else
            {
                return null;
            }
            return car;
        }
    }
}
