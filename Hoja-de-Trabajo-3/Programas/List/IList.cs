using System;

namespace IList
{
    public interface IList<T>
    {
        public bool Get(int indice, out int resultado)
        {
            
        }

        public bool Set(int indice, T elemento)
        {

        }
        
        public void Push(T elemento)
        {
            IList<T> lista = this;

            while(lista.Resto != null)
            {
                lista = lista.Resto;
            }

            lista.Resto = new IList<T>(elemento);            
        }

        public int Length
        { get
            {
                Ilist<T> lista = this;
                int length = 0;

                while(lista.Resto != null)
                {
                    lista = lista.Resto;
                    length++;
                }
            }
                return length;                
            }
        }

    }
}