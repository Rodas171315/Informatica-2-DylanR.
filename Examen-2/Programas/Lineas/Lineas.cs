using System;
using System.Collections.Generic;

namespace Lineas
{
    public abstract class LineaAbstracta<T> : ILinea<T>
    {
        public abstract double Distancia(T elemento1, T elemento2);

        public abstract class T[] Puntos {get;}

        public double Longitud() 
        {
            if (Puntos.Length == 0 || Puntos.Length == 1)
            {
                return 0;
            }

            for (int i = 0; i < Puntos.Length; i++)
            {
                if (i == Puntos.Length)
                { 
                    break; 
                }

                longitud += Distancia(Puntos[i], Puntos[i + 1]);
            }
            return longitud;
        }
    
        public T PuntoMasCercano(T elemento)
        {
            T PuntoMasCercano = Puntos[0];

            for(int i = 0; i < Puntos.Length; i++)
            {
                if (Distancia(elemento, Puntos[i]) < Distancia(elemento, PuntoMasCercano))
                {
                    PuntoMasCercano = Puntos[i];
                }
            }
            return PuntoMasCercano;
        }

        public class Punto2D
        {
            public double X{get;}
            public double Y{get;}

            public Punto2D(double x, double y){
                this.X = x;
                this.Y = y;
            }
        }

        public class Punto3D
        {
            public double X{get;}
            public double Y{get;}
            public double Z{get;}

            public Punto3D(double x, double y, double z){
                this.X = x;
                this.Y = y;
                this.Z = z;
            }
        }
    }
}