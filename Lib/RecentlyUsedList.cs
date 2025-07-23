namespace Utils
{
    public class RecentlyUsedList
    {
        private LinkedList<string> storage = new LinkedList<string>();

        public void Add(string item)
        {
            this.storage.AddFirst(item);
        }

        public string this[int i]
        {
            get => this.storage.ElementAt(i);
        }

        public int Length => this.storage.Count;
    }
}
