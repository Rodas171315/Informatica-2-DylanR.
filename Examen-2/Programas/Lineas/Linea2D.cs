using System;
using System.Collections.Generic;

namespace Linea2D
{
    public class Linea2D : LineaAbstracta<Punto2D>
    {
        public override Puntos2D[] Puntos();

        public override double Distancia(Punto2D elemento1, Punto2D elemento2)
        {
            double distancia;

            double x = Math.Pow(elemento1.X - elemento2.X, 2);
            double y = Math.Pow(elemento1.Y - elemento2.Y, 2);

            distancia = Math.Sqrt(x+y);
            return distancia;

        }

        public Linea2D(Punto2D[] Puntos)
        {
            Puntos = puntos;
        }          
    }   
}