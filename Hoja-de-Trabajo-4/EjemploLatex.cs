class EjemploLatex
{
    public static object Head(object[] arreglo)
    {
        return arreglo[0];
    }

    public static T HeadGenerico<T>(T[] arreglo)
    {
        return arreglo[0];
    }

    public static void Prueba()
    {
        //Esto provoca un error en tiempo de compilacion, debido a una excepcion
        //de casteo no valido por intentar castear una cadena a un entero.
        string[] valoresStr = new string[];
        valoresStr.Add("Enero");
        valoresStr.Add("Diciembre");
        int resultado = (int)Head(valoresStr);

        //Pero el metodo generico, permite mantener un control del tipo de dato
        //que se obtendra y no hay necesidad de boxing, ni casteo.
        int[] valoresInt = new int[];
        valoresInt.Add(2017);
        valoresInt.Add(2018);
        int resultadoInt = HeadGenerico(valoresInt);   
    }
}