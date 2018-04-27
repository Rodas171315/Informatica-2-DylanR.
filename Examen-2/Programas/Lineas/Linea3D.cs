using System;
using System.Collections.Generic;

namespace Linea3D
{
    public class Linea3D : LineaAbstracta<Punto3D>
    {
        public override Puntos3D[] Puntos();

        public override double Distancia(Punto3D elemento1, Punto3D elemento2)
        {
            double distancia;

            double x = Math.Pow(elemento1.X - elemento2.X, 2);
            double y = Math.Pow(elemento1.Y - elemento2.Y, 2);
            double z = Math.Pow(elemento1.Z - elemento2.Z, 2);

            distancia = Math.Sqrt(x+y+z);
            return distancia;

        }

        public Linea3D(Punto3D[] Puntos)
        {
            Puntos = puntos;
        }
    }    
}