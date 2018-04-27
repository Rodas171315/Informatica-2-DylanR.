using System;
using System.Collections.Generic;

namespace Lineas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Polimorfismo!");
        }
    }

    public class PoliFail()
    {
        public static void main(string[] args)
        {
            /* Ejemplo donde utilizar el polimorfismo para arreglos puede llevar a que el
            programa falle durante la ejecucion, a pesar que los tipos estan correctos */

            string[] arreglo = new string[]{};
            object[] objetos = arreglo;
        }
    }
}
