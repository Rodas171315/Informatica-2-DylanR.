using System;

namespace IList
{
    public interface IList<T>
    {
        bool Get(int indice, out int )
        {
            
        }

        bool Set(int indice, T elemento)
        {

        }
        
        void Push(T elemento)
        {

        }

        int Length{get;}
    }
}