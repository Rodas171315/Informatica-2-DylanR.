using System;
using Xunit;

namespace GenericosTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class TestHead
    {
        [Fact]
        public void PrimerValor()
        {
            int[] valores = new int[]{1,2,3};
            int resultado = Program.Head(valores);
            Assert.Equals(1, resultado);
        }        
    }
}
