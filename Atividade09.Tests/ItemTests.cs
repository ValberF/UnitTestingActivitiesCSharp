using Xunit;
using System;
using System.Collections.Generic;

namespace Atividade09.Tests
{
    public class ItemCollectionTests
    {
        [Fact]
        public void AddItem_ShouldAddItemToList_WhenItemIsValid()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Test Pen");

            itemCollection.AddItem(item);

            Assert.Contains(item, itemCollection.GetItems());
        }

        [Fact]
        public void AddItem_ShouldThrowArgumentException_WhenItemIsNull()
        {
            var itemCollection = new ItemCollection();

            Assert.Throws<ArgumentException>(() => itemCollection.AddItem(null));
        }

        [Fact]
        public void RemoveItem_ShouldRemoveItemFromList_WhenItemExists()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Test Pen");
            itemCollection.AddItem(item);

            itemCollection.RemoveItem(item);

            Assert.DoesNotContain(item, itemCollection.GetItems());
        }

        [Fact]
        public void RemoveItem_ShouldThrowArgumentException_WhenItemDoesNotExist()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Test Pen");

            Assert.Throws<ArgumentException>(() => itemCollection.RemoveItem(item));
        }

        [Fact]
        public void GetItems_ShouldReturnAllItems()
        {
            var itemCollection = new ItemCollection();
            var item1 = new Item("Pen 1");
            var item2 = new Item("Pen 2");
            itemCollection.AddItem(item1);
            itemCollection.AddItem(item2);

            var items = itemCollection.GetItems();

            Assert.Equal(2, items.Count);
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }
    }
}
