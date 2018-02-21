using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Lista
    {
        public void Push()
        {
            
        }
    }

    public class ArrayList : IList<T>
    {
        T almacenamiento {get; private set;}
        
        int [] Arreglo = new int [almacenamiento.Legth + 1]

    }
}
