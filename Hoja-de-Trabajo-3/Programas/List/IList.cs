using System;
using System.Collections.Generic;

namespace IList
{
    public interface IList<T> where T: new()
    {
        public bool Get(int indice, out T resultado);

        public bool Set(int indice, T elemento);
        
        public void Push(T elemento);

        public int Length{ get; }
    }
}