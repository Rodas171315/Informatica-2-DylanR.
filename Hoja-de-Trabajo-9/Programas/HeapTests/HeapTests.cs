using System;
using Xunit;
using Heap;

namespace HeapTests
{
    public class HeapTests
    {
        [Fact]
        public void TestHeapify()
        {
			int[] arreglo = { 10, 20, 30, 100, 10, 3, 2, 1 };

            int[] actual = arreglo.Heapify();
            int[] expected = new int[] { 100, 30, 20, 10, 3, 2, 1 };

            Assert.Equal(expected, actual);           
        }
    }
}
