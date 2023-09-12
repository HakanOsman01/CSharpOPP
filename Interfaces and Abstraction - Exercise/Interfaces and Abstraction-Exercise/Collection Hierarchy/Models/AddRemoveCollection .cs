



namespace Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public override List<string> Add(string[] inputElements)
        {
            List<string> elements = inputElements.ToList();
            const int startIndex = 0;
            for (int i = 0; i < inputElements.Length; i++)
            {
                Console.Write($"{startIndex} ");
                elements.Insert(startIndex, inputElements[i]);
            }
            return elements;
        }
        public virtual void Remove(List<string>elements,int count)
        {
            string[]array = new string[count];
           for (int i = count;i > 0;i--)
           {
                array[i-1]= elements.Last();
                //Console.Write($"{removeElement} ");
                elements.RemoveAt(elements.Count-1);
                

           }
           
            for (int i = array.Length-1;i >=0; i--)
            {
                Console.Write($"{array[i]} ");
            }

            //Console.WriteLine($"{string.Join(" ",array)}");
        }
       
    }
}
