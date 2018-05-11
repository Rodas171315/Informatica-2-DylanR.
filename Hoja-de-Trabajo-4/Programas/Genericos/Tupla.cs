using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupla
{
    public class Tupla<T1, T2>
    {
        public T1 Primero { get; }
        public T2 Segundo { get; }

        public Tupla(T1 primero, T2 segundo)
        {
            this.Primero = primero;
            this.Segundo = segundo;
        }
    }
}