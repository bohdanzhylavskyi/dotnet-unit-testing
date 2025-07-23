namespace Utils.Tests
{
    public class RecentlyUsedListTests
    {
        [Fact]
        public void RecentlyUsedList_AddSingleItem_ProcessedCorrectly()
        {
            var list = new RecentlyUsedList();
            var item = "item";

            list.Add(item);

            Assert.Equal(1, list.Length);
            Assert.Equal(list[0], item);
        }

        [Fact]
        public void RecentlyUsedList_AddMultipleItems_ProcessedCorrectly()
        {
            var list = new RecentlyUsedList();
            var item1 = "item 1";
            var item2 = "item 2";

            list.Add(item1);
            list.Add(item2);

            Assert.Equal(2, list.Length);
            Assert.Equal(list[0], item2);
            Assert.Equal(list[1], item1);
        }

        [Fact]
        public void RecentlyUsedList_AddDuplicates_ListContainsOnlyUniqueItems()
        {
            var list = new RecentlyUsedList();
            var item = "item";

            list.Add(item);
            list.Add(item);

            Assert.Equal(1, list.Length);
            Assert.Equal(list[0], item);
        }

        [Fact]
        public void RecentlyUsedList_AddDuplicates_DuplicatedItemMovedRatherThanAdded()
        {
            var list = new RecentlyUsedList();
            var item1 = "item 1";
            var item2 = "item 2";

            list.Add(item1);
            list.Add(item2);
            list.Add(item1);

            Assert.Equal(2, list.Length);
            Assert.Equal(list[0], item1);
            Assert.Equal(list[1], item2);
        }
    }
}