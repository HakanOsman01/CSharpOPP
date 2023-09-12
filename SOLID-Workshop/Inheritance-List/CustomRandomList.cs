

namespace Inheritance_List
{
    public class CustomRandomList : List<string>
    {
        private Random random;
        public CustomRandomList()
        {
            random = new Random();
        }
        public string RandomString()
        {
            int index=random.Next(0,this.Count);
            string removedElement = this[index];
            this.RemoveAt(index);
            return removedElement;
        }
    }
}
