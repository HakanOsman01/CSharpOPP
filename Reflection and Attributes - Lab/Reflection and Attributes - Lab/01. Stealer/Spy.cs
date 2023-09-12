using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
       public string StealFieldInfo(string className,params string[] fields)
       {
            StringBuilder builder = new StringBuilder();

            Type type = Type.GetType(className);
            Hacker hacker=new Hacker();
            builder.AppendLine($"Class under investigation: {type.FullName}");
            FieldInfo[]fieldsinfo=type.GetFields(BindingFlags.Public 
                | BindingFlags.Instance 
                | BindingFlags.Static | BindingFlags.NonPublic)
                .ToArray();
           
            foreach (FieldInfo currentField in fieldsinfo)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    if (currentField.Name == fields[i])
                    {
                        builder.AppendLine($"{currentField.Name} = " +
                            $"{currentField.GetValue(hacker)}");
                    }
                }
            }
            return builder.ToString().TrimEnd();
       }
        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder builder = new StringBuilder();

            Type type = Type.GetType(className);
            FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.Public );
            MethodInfo[] publicMehodInfo = type.GetMethods(BindingFlags.Instance
                | BindingFlags.Public);
            MethodInfo[] nonPublicMethodsInfo = type.GetMethods(BindingFlags.Instance
                | BindingFlags.NonPublic);
            foreach (FieldInfo field in fieldInfo)
            {
               
                 builder.AppendLine($"{field.Name} must be private!");
                

            }
            foreach (MethodInfo method in nonPublicMethodsInfo.Where(p=>p.Name.StartsWith("get")))
            {
               
                builder.AppendLine($"{method.Name} have to be public!");
                
            }
            foreach (MethodInfo method in publicMehodInfo.Where(p=>p.Name.StartsWith("set")))
            {
               
               builder.AppendLine($"{method.Name} have to be public!");
                
            }
            return builder.ToString();
            

        }
       public string RevealPrivateMethods(string className)
       {
            StringBuilder stringBuilder = new StringBuilder();
            Type type = Type.GetType(className);
            stringBuilder.AppendLine($"All Private Methods of Class: {type.FullName}");
            stringBuilder.AppendLine($"Base Class: {type.BaseType.Name}");
            MethodInfo[] privatesMethodsInfo = type.GetMethods(BindingFlags.Instance 
                | BindingFlags.NonPublic);
            foreach (MethodInfo  method in privatesMethodsInfo)
            {
                stringBuilder.AppendLine($"{method.Name}");
            }
            return stringBuilder.ToString().Trim();

       }
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Type type=Type.GetType(className);
            BindingFlags bindingFlags = (BindingFlags)60;
            MethodInfo[] getters = type.GetMethods(bindingFlags);
            MethodInfo[]setters=type.GetMethods(bindingFlags);
            List<object> parameters = new List<object>();

            foreach (MethodInfo getmethod in getters.Where(g => g.Name.StartsWith("get")))
            {
               
                stringBuilder.AppendLine($"{getmethod.Name} will return " +
                    $"{getmethod.ReturnParameter.ParameterType}");
                parameters.Add(getmethod.ReturnParameter.ParameterType);
            }
            int index = 0;
            foreach (MethodInfo setmethod in setters.Where(s=>s.Name.StartsWith("set")))
            {
                 
                //PropertyInfo property = type.GetProperty(setmethod.Name);
               
                stringBuilder.AppendLine($"{setmethod.Name} will set " +
                    $"field of {parameters[index++]}");
            }
            return stringBuilder.ToString().Trim();

        }
    }
}
