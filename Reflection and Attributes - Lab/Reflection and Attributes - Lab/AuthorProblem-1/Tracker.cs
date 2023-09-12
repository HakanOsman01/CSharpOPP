using System.Reflection;

namespace AuthorProblem_1
{
    
    public class Tracker
    {
       public void PrintMethodsByAuthor()
       {
            var type = typeof(StartUp);
         
                 MethodInfo[] methods=type.GetMethods(BindingFlags.Instance 
                     | BindingFlags.Public | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                if (method.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute atr in attributes)
                    {
                        Console.WriteLine("{0} is written by {1}",method.Name,atr.Name);
                    }
                }
  
            }

          
       }
    }
}
