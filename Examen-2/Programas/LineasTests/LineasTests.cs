using System;
using System.Collections.Generic;
using Xunit;

namespace LineasTests
{
    public class LineasTests
    {
        [Fact]
        public void testLongitud()
        {
            double[] Puntos = new double[]{10, 50};
            double longitud = Puntos.Longitud();

            Assert.Equal(2, longitud);
        }

        [Fact]
        public void TestPuntoMasCercano()
        {
            double[] Puntos = new double[]{4, 6, 8, 10};
            double PtMasCercano = Puntos.PuntoMasCercano(3);

            Assert.Equal(4, PtMasCercano);            
        }
    }
}
