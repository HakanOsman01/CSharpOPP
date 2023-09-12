
namespace Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class MyList : AddRemoveCollection,IMyList
    {
        public int Used => throw new NotImplementedException();

       

        public override List<string> Add(string[] inputElements)
        {
            return base.Add(inputElements);
        }
        public override void Remove(List<string> elements, int count)
        {
            string[] array = new string[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = elements.First();
                //Console.Write($"{removeElement} ");
                elements.RemoveAt(0);


            }
            Console.WriteLine($"{string.Join(" ", array)}");
        }
    }
}
