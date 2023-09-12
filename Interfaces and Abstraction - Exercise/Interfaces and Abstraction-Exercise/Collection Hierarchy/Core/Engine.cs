


namespace Collection_Hierarchy.Core
{
    using Collection_Hierarchy.Models;
    using Collection_Hierarchy.Models.Interfaces;
    using Interfaces;
    public class Engine : IEngine
    {
        public void Run()
        {
            IAddCollection addCollection=new AddCollection();

            IAddRemoveCollection removeCollection=new AddRemoveCollection();
            IMyList myList=new MyList();
            string[]elements=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int countRemoveElements=int.Parse(Console.ReadLine());
            List<string>list=addCollection.Add(elements);
            Console.WriteLine();
          
            
            list.InsertRange(0,removeCollection.Add(elements));
            Console.WriteLine();
            list.InsertRange(0,myList.Add(elements));
            Console.WriteLine();
            removeCollection.Remove(list,countRemoveElements);
            Console.WriteLine();
            myList.Remove(list,countRemoveElements);


        }
    }
}
