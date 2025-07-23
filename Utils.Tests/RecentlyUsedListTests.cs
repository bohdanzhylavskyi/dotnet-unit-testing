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

        [Fact]
        public void RecentlyUsedList_AddMoreItemsThanMaxSize_OverflowedItemsDropped()
        {
            var size = 3;
            var list = new RecentlyUsedList(size);

            var item1 = "item 1";
            var item2 = "item 2";
            var item3 = "item 3";
            var item4 = "item 4";

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);

            Assert.Equal(3, list.Length);
            Assert.Equal(list[0], item4);
            Assert.Equal(list[1], item3);
            Assert.Equal(list[2], item2);
        }
    }
}