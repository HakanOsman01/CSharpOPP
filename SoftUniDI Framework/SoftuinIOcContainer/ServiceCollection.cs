using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuinIOcContainer
{
    public class ServiceCollection
    {
       private Dictionary<Type, Type> mappings;
        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();
        }
        private void RegisterMapping(Type typeInterface,Type implemantaionType)
        {
            mappings[typeInterface] = implemantaionType;
        }
        public void AddTransite<Tinterface,Timplemantaion>()
        {

            RegisterMapping(typeof(Tinterface), typeof(Timplemantaion));
        }
        public ServiceProvider BuildSurviceProvider()
        {
            return new ServiceProvider(this);
        }
    }
}
