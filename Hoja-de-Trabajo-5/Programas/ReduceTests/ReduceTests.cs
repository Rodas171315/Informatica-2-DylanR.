using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReduceTests
{
    public class ReduceTests
    {
        [Fact]
        public void ReduceIntTest()
        {
            //Suma de los valores de un arreglo
            int[] valores = new int[] { 1, 2, 3, 4, 5, 6 };
            int reduce = Program.ReduceInt(valores, 0, (acc, valor) => acc + valor);

            Assert.AreEqual(reduce, 21);
        }

        [Fact]
        public void ReduceGenericTest()
        {
            //Suma la cantidad de veces que aparece la letra <o> en los elementos del arreglo
            string[] valores = new string[] { "hola", "mundo", "loco", "Rodas" };
            int reduce = Program.Reduce(valores, 0, (acc, valor) => acc + valor.Where(c => c == 'o').Count());

            Assert.AreEqual(reduce, 5);
        }
    }
}
