using Algorithms.Search;
using System;
using Xunit;

namespace UnitTests
{
    public class SearchTest
    {
        [Fact]
        public void BinarySearchPass()
        {
            int[] arr = new int[] { 1, 2, 3, 5, 87, 98, 345, 7654, 30343, 54534534 };
            Search objSearch = new Search();
            int result=objSearch.BinarySearch(arr, 87);
            Assert.Equal(87, result);
        }
    }
}
