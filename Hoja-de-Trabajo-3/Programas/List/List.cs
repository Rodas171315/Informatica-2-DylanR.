using System;
using System.Collections.Generic;

namespace List
{
    public abstract class Lista<T> : IList<T> where T : new()
    {
        public abstract bool Get(int indice, out T resultado);
        
        public abstract bool Set(int indice, T elemento);
        
        public abstract int Length();
        
        public abstract void Push(T elemento);
        
        public abstract void Push(IList<T> elemento)
        {
            for (int i = 0; i < elemento.Length; i++)
            {
                T nuevo = new T();
                elemento.Get(indice, out nuevo);
                Push(nuevo);
            }
        }        
    }
}