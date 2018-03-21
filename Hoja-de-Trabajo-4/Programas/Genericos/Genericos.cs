﻿using System;
using System.Collections.Generic;

namespace Genericos
{
    class Genericos
    {
        public static T Head<T>(T[] arreglo)
        {
            return arreglo[0];
        }

        public static T[] Tail<T>(T[] arreglo)
        {
            List<T> arr = arreglo.ToList();
            arr.RemoveAt(0);
            T[] arregloNuevo = arr.ToArray<T>();

            return arregloNuevo;
        }

        public static Tupla<T1, T2>[] Zip<T1, T2>(T1[] primero, T2[] segundo)
        {
            Tupla<T1, T2>[] arreglo = new Tupla<T1, T2>[primero.Length < segundo.Length ? primero.Length : segundo.Length];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = new Tupla<T1, T2>(primero[i], segundo[i]);
            }

            return arreglo;
        }
    }
}
