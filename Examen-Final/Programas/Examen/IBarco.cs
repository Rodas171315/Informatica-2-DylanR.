using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBarco
{
    public interface IBarco
    {
        bool Atacar(int valor);

        bool EstaHundido();

        int Longitud{get;}

        int X{get;}

        int Y{get;}

        int Orientacion{get;}
        
    }
}