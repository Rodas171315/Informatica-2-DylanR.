using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ListTests
{
    public class ListTests
    {
        [Fact]
        public void Test1()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            IList<int> lista = new ArrayList<int>(arreglo);
            lista.Push(6);
            Assert.AreEqual(arreglo.Length, 6);

            int elemento = 0;
            lista.Get(lista.Length() - 1, out elemento);
            Assert.AreEqual(elemento, 6);
        }
            
        [Fact]
        public void Test2()
        {
            int[] arreglo = {2,3,4,5};
            IList<int> lista = new ArrayList<int>(arreglo);

            int elemento = 0;
            Assert.AreEqual(lista.Get(5, out int elemento), false);
        }

        [Fact]
        public void Test3()
        {
            int[] arreglo = {10,20,30};
            IList<int> lista = new ArrayList<int>(arreglo);
            lista.Set(1, 40);

            int elemento;
            lista.Get(1, out elemento);
            Assert.AreEqual(elemento, 40);
        }
    }
}