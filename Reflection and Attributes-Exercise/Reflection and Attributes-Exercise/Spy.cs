using Stealer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_and_Attributes_Exercise
{
    public class Spy
    {
       public string StealFieldInfo(string nameClass, params string[]fields)
       {
            StringBuilder sb= new StringBuilder();
            Type type=Type.GetType(nameClass);
            sb.AppendLine($"Class under investigation: {type.FullName}");
            FieldInfo[]fieldsInfo=type.GetFields((BindingFlags)60);
            Hacker hackerInstance =(Hacker)
                Activator.CreateInstance(type,new object[] { });
            foreach (FieldInfo field in fieldsInfo)
            {
                //object value = field.GetValue(new object[]{});
                if (fields.Contains(field.Name))
                {
                    sb.AppendLine($"{field.Name} = {field.GetValue(hackerInstance)}");
                }
              
            }
            return sb.ToString().TrimEnd();


       }
        public string AnalyzeAccessModifiers(string className)
        {
            Type typeClass = Type.GetType(className);
            StringBuilder sb=new StringBuilder();

            FieldInfo[] fieldsInfo = typeClass.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach (FieldInfo field in fieldsInfo)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            PropertyInfo[]propertyInfos=typeClass.GetProperties(BindingFlags.Instance | )
        }
    }
}
