using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HeapSortTests
{
    public class HeapSortTests
    {
        [Fact]
        public void TestHeapSort()
        {
			int[] arreglo = new int[] { 10, 20, 30, 100, 3, 2, 1 };

			int[] actual = Programa.HeapSort(arreglo);
            int[] expected = new int[] { 100, 30, 20, 10, 3, 2, 1 };

			Assert.Equal(expected, actual);           
        }
    }
}
