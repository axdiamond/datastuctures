using System.Linq;
using NUnit.Framework;
using Datastructures.MaxHeaps;

namespace Datastructures.MaxHeaps.Tests
{
    public class Tests
    {
        [Test]
        public void SortsProperly()
        {
            var input = new []{ 2, 5, 1, 6, 3 };
            var correct = new []{ 6, 5, 1, 2, 3 };

            var heap = new MaxHeap(input);
            var result = heap.GetSorted();

            Assert.AreEqual(correct, result);
        }
    }
}