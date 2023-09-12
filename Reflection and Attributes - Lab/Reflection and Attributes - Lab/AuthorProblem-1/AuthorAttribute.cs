using System.Reflection;

namespace AuthorProblem_1
{
    [AttributeUsage( AttributeTargets.Method | AttributeTargets.Class,AllowMultiple =true)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name) 
        {
            Name = name;
        }

        public string Name { get; private set; }
       
    }
   
}
