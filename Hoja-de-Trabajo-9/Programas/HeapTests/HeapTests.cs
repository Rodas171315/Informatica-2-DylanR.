using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Heap;

namespace HeapTests
{
    public class HeapTests
    {
        [Fact]
        public void TestHeapify()
        {
			int[] arreglo = { 10, 20, 30, 100, 3, 2, 1 };

            int actual = Programa.Heapify(arreglo);
            int[] expected = new int[] { 100, 30, 20, 10, 3, 2, 1 };

            Assert.Equal(expected[0], actual);           
        }
    }
}
