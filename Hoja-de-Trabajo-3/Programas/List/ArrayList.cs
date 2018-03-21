using System;
using System.Collections.Generic;

namespace ArrayList
{
    public class ArrayList : IList<T> where T: new()
    {
        private T[] Almacenamiento {get; private set;}
        
        public ArrayList(T[] elemento)
        {
            this.Almacenamiento = elemento;
        }

        public override bool Get(int indice, out T resultado)
        {
            resultado = new T();
            if (indice >= Almacenamiento.Length)
            {
                return false;
            }
            else
            {
                resultado = Almacenamiento[indice];
                return true;
            }
        }

        public override int Length()
        {
            get => Almacenamiento.Length;
        }

        public override void Push(T elemento)
        {
            T[] arr = new T[Almacenamiento.Length + 1];
            for (int i = 0; i < Almacenamiento.Length; i++)
            {
                arr[i] = Almacenamiento[i];
            }
            arr[arr.Length - 1] = elemento;
            Almacenamiento = arr;            
        }

        public override bool Set(int indice, T elemento)
        {
            if (indice >= Length())
            {
                return false;
            }
            else
            {
                Almacenamiento[indice] = elemento;
                return true;
            }
        }

        public override void Push(IList<T> elemento)
        {
            IList<T> lista = this;

            while(lista.Resto != null)
            {
                lista = lista.Resto;
            }

            lista.Resto = new IList<T>(elemento);
        }
    }
}