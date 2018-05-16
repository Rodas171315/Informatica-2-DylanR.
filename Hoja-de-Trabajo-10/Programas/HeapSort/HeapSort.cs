using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class Programa
    {
		public static int Heap;

		public static int[] HeapSort(int[] arreglo) {
			
            int numero = arreglo.Length;
			
			for (int i = numero / 2 - 1; i >= 0; i--)
				ShiftDown(arreglo, numero, i);

			for (int i = numero - 1; i >= 0; i--)
			{
				int temp = arreglo[0];
				arreglo[0] = arreglo[i];
				arreglo[i] = temp;

				ShiftDown(arreglo, i, 0);
			}
			return arreglo;
		}

		public static void ShiftDown(int[] arreglo, int numero, int i)
		{

			int mayornumero = i;
			int Izquierdo = 2 * i + 1;
			int Derecho = 2 * i + 2;

			if (Izquierdo < numero && arreglo[Izquierdo] > arreglo[mayornumero])
				mayornumero = Izquierdo;

			if (Derecho < numero && arreglo[Derecho] > arreglo[mayornumero])
				mayornumero = Derecho;

			if (mayornumero != i)
			{
				int swap = arreglo[i];
				arreglo[i] = arreglo[mayornumero];
				arreglo[mayornumero] = swap;

				ShiftDown(arreglo, numero, mayornumero);
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
