using System;
using Xunit;

namespace ReduceTests
{
    [TestClass]
    public class ReduceTests
    {
        [TestMethod]
        public void ReduceIntTest()
        {
            //Suma de los valores de un arreglo
            int[] valores = new int[] { 1, 2, 3, 4, 5, 6 };
            int reduce = Program.ReduceInt(valores, 0, (acc, valor) => acc + valor);

            Assert.AreEqual(reduce, 21);
        }

        [TestMethod]
        public void ReduceGenericTest()
        {
            //Suma la cantidad de veces que aparece la letra <o> en los elementos del arreglo
            string[] valores = new string[] { "hola", "mundo", "loco", "Rodas" };
            int reduce = Program.Reduce(valores, 0, (acc, valor) => acc + valor.Where(c => c == 'o').Count());

            Assert.AreEqual(reduce, 5);
        }
    }
}
