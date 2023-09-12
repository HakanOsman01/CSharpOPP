namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int indexRemove=random.Next(0, this.Count);
            string removeElenment = this[indexRemove];
            this.RemoveAt(indexRemove);
            return removeElenment;
        }
    }
}
