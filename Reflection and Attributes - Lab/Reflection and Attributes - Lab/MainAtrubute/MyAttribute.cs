using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAtrubute
{
    [AttributeUsage(AttributeTargets.Method | 
        AttributeTargets.Class, AllowMultiple = true)]
    public class MyAttribute : Attribute
    {
        public MyAttribute(string name="") 
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
