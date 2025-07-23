namespace Utils
{
    public class RecentlyUsedList
    {
        private LinkedList<string> storage = new LinkedList<string>();

        public void Add(string item)
        {
            var listNodeWithIdenticalValue = this.storage.Find(item);

            if (listNodeWithIdenticalValue != null)
            {
                this.storage.Remove(listNodeWithIdenticalValue);
            }

            this.storage.AddFirst(item);
        }

        public string this[int i]
        {
            get => this.storage.ElementAt(i);
        }

        public int Length => this.storage.Count;
    }
}
