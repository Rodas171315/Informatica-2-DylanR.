using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GenericosTests
{
    public class GenericosTests
    {
        [Fact]
        public void TestHead()
        {
            int[] valores = new int[]{1,2,3};
            int resultado = Program.Head(valores);

            Assert.Equals(1, resultado);
        }

        [Fact]
        public void TestTail()
        {
            int[] valores = new int[] { 1, 2, 3, 4, 5 };
            int[] resultado = Genericos.Genericos.Tail(valores);

            Assert.AreEqual(resultado.Length, valores.Length - 1);
            Assert.AreEqual(resultado[0], valores[1]);
        }

        [Fact]
        public void TestZip()
        {
            int[] valores1 = new int[] { 1, 2, 3, 4, 5 };
            string[] valores2 = new string[] { "uno", "dos", "tres", "cuatro", "cinco" };

            Tupla<int, string>[] resultado = Genericos.Genericos.Zip(valores1, valores2);

            Assert.AreEqual(resultado.Length, valores2.Length);

            for (int i = 0; i < resultado.Length; i++)
            {
                Assert.AreEqual(resultado[i].Primero, valores1[i]);
                Assert.AreEqual(resultado[i].Segundo, valores2[i]);
            }
        }                         
    }
}
