using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBinTree
{
    public interface IBinTree{
    int Valor {get;}

    IBinTree Derecho {get;}

    IBinTree Izquierdo {get;}

    int Sumar();

    int[] ToArray();

    void Insert(int value);
    }
}