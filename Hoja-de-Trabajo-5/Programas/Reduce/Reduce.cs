using System;
using System.Collections.Generic;

namespace Reduce
{
    class Reduce
    {
        public static int ReduceInt(int[] arreglo, int inicial, Func<int, int, int> reduce)
        {
            int acumulador = inicial;

            for (int i = 0; i < arreglo.Length; i++)
            {
                acumulador = reduce(acumulador, arreglo[i]);
            }

            return acumulador;
        }

        public static A Reduce<T, A> (T[] arreglo, A inicial, Func<A, T, A> reduce)
        {
            A acumulador = inicial;

            for (int i = 0; i < arreglo.Length; i++)
            {
                acumulador = reduce(acumulador, arreglo[i]);
            }

            return acumulador;
        }
    }
}
