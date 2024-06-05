using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Atividade11.Tests
{
    public class CustomSorterTests
    {
        [Fact]
        public void SortDescending_ShouldSortListInDescendingOrder_WhenListHasMultipleElements()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int> { 1, 3, 5, 4, 2 };

            var result = sorter.SortDescending(numbers);

            var expected = new List<int> { 5, 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldReturnEmptyList_WhenListIsEmpty()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int>();

            var result = sorter.SortDescending(numbers);

            Assert.Empty(result);
        }

        [Fact]
        public void SortDescending_ShouldHandleSingleElementList()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int> { 42 };

            var result = sorter.SortDescending(numbers);

            var expected = new List<int> { 42 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldHandleAlreadySortedDescendingList()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int> { 5, 4, 3, 2, 1 };

            var result = sorter.SortDescending(numbers);

            var expected = new List<int> { 5, 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldHandleListWithDuplicateElements()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int> { 4, 2, 4, 3, 1 };

            var result = sorter.SortDescending(numbers);

            var expected = new List<int> { 4, 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }
    }
}
