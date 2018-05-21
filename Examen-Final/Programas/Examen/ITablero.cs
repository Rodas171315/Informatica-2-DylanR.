using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITablero
{
    public interface ITablero: IBarco
    {
        bool ColocarBarco(IBarco barco);

        bool Atacar(int x, int y);

        bool EstaConcluido();

        int Capacidad{get;}

    }
}