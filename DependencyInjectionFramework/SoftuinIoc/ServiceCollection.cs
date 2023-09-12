using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuinIoc
{
    public class ServiceCollection
    {
        private Dictionary<Type, Type> mappings;

        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();
        }
        private void RegisterMapping(Type interfaceType,Type implemantaionType)
        {
            mappings[interfaceType] = implemantaionType;
        }
        public void AddTransite<TinterfaceType, TimplemantaionType>()
        {
            RegisterMapping(typeof(TinterfaceType),typeof(TimplemantaionType));
        }
        public ServiceProvider BuidlServiceProvider()
        {
            return new ServiceProvider(this); 
        }
    }
}
