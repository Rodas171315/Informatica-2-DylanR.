using System;
using System.Collections.Generic;

namespace ILinea
{
    public interface ILinea<T>
    {
        double Longitud();

        T PuntoMasCercano (T elemento);
    }
}