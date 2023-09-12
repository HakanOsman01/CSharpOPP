using System.Reflection;
using System.Linq;
namespace AuthorProblem
{

    [Author("Pesho")]
    public class StartUp
    {
        [Author("Dimitricho")]
        static void Main(string[] args)
        {
            Type[]types=Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                AuthorAttribute authorAttribute =type
               .GetCustomAttributes()
               .FirstOrDefault(a=>a.GetType()==typeof(AuthorAttribute))
                   as AuthorAttribute;
                if (authorAttribute != null)
                {
                    Console.WriteLine($"Class name atrribute-{authorAttribute.Name}");
                }
                MethodInfo[] methodInfos = type.GetMethods();
                foreach (MethodInfo method in methodInfos)
                {
                    authorAttribute = method.GetCustomAttributes()
                .FirstOrDefault(a => a.GetType() == typeof(AuthorAttribute))
                   as AuthorAttribute;
                    if (authorAttribute != null)
                    {
                        Console.WriteLine($"Method name atrribite-{method.Name}");
                    }
                }
                
            }
        }
        [Author("Unknown")]
        public void MyMethod() 
        {
            Console.WriteLine("Print");
        }
    }
}