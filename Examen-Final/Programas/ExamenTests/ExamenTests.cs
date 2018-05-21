using System;
using Xunit;

namespace ExamenTests
{
    public class ExamenTests
    {
        [Fact]
        public void TestColocarBarco()
        {
        int[][] tablero = new int [][] {
            [
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0]
            ]
        };

        int[] barco = new Barco(3,2,1,1);

        var actual = ColocarBarco(barco);
        var expected = true;

        Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestAtacar()
        {
            
        }

        [Fact]
        public void TestEstaConcluido()
        {
            
        }                
    }
}
