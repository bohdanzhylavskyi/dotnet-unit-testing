using System.Linq;

namespace Utils
{
    public class RecentlyUsedList
    {
        private LinkedList<string> storage = new LinkedList<string>();
        private int? size = null;

        public RecentlyUsedList()
        {
        }

        public RecentlyUsedList(int size)
        {
            this.size = size;
        }

        public void Add(string item)
        {
            var listNodeWithIdenticalValue = this.storage.Find(item);

            if (listNodeWithIdenticalValue != null)
            {
                this.storage.Remove(listNodeWithIdenticalValue);
            }

            this.storage.AddFirst(item);

            if (size != null && this.storage.Count > size)
            {
                var overflowedNode = this.storage.ElementAt(size.Value);
                this.storage.Remove(overflowedNode);
            }
        }

        public string this[int i]
        {
            get => this.storage.ElementAt(i);
        }

        public int Length => this.storage.Count;
    }
}
