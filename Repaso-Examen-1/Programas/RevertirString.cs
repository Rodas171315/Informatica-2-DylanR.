using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programas
{
    public class Revertir
    {
        public Operador Palabras {get; set;}

        public Revertir(string palabras)
        {
            this.Palabras = palabras;
            this.Palabras = new Operador();
        }

        public void RevertirString()
        {
            String cadena = "";
            String Palabras;

            int t = Palabras.Length;

            for(int i = t - 1 ; i >= 0 ; i--)
            {
                cadena = cadena + Palabras.Substring(i, 1);
            }

            Console.WriteLine(cadena);            
        }
    }
}