using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Heap
    {
        public static int Heapy;

        public static void Heapify(int[] arreglo)
		{
			Heapy = arreglo.Length - 1;

			for (int i = floop(arreglo.Length); i >= 0; i--)
			{
				ShiftDown(arreglo, i);
			}
		}      
      
        public static void ShiftDown(int[] arreglo, int i)
        {
			int izquierdo = Izquierdo(i);
			int derecho = Derecho(i);

			int indice = 0;

			// Check to see which node in the tree subset has the largest value
			if (izquierdo <= Heapy && arreglo[izquierdo] > arreglo[i])
			{
				indice = izquierdo;
			}
			else
			{
				indice = i;
			}
			if (derecho <= Heapy && arreglo[derecho] > arreglo[indice])
			{
				indice = derecho;
			}

			// Do not make any switches if the largest node is the parent
			if (indice != i)
			{
				int temp = arreglo[indice];
				arreglo[indice] = arreglo[i];
				arreglo[i] = temp;
				ShiftDown(arreglo, indice);
			}           
        }

		private static int floop(int currentIndex)
		{
			return (currentIndex - 1)/ 2;
		}

		private static int Izquierdo(int currentIndex)
		{
			return currentIndex * 2 + 2;
		}

		private static int Derecho(int currentIndex)
		{
			return currentIndex * 2 + 1;
		}          

    }
}