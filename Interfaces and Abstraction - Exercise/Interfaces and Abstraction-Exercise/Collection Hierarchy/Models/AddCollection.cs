


namespace Collection_Hierarchy.Models
{
    using Interfaces;
    public class AddCollection : IAddCollection
    {
        public virtual List<string> Add(string[]inputElements)
        {
            List<string> elements=new List<string>();
            for (int i = inputElements.Length-1; i >= 0; i--)
            {
                Console.Write($"{elements.Count} ");
                elements.Add(inputElements[i]);

            }
            return elements;
           

        }

        
    }
}
