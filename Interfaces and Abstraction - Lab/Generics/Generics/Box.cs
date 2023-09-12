
namespace Generics
{
    public class Box<T>
    {
        private List<T> list;
        public Box()
        {
            list = new List<T>();
            
        }
       public void Add(T element)
       { 
            list.Add(element);
       }
       public T Remove()
       {
            T removeElement = list.Last();
            list.RemoveAt(list.Count - 1);
            return removeElement;

       }
        public int Count 
        { 
            get
            {
                return list.Count;
            } 

        }

    }
}
