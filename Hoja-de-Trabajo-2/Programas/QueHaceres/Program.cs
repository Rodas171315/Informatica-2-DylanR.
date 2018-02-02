using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueHaceres
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona("Dylan", "Rodas");
            Persona Persona2 = new Persona("Juana", "Vivar");

            QueHacer QueHacer1 = new QueHacer(new DateTime(2018, 2, 1, 6, 50, 00), "Tarea Sumas", "ejecuta una adicion entre dos elementos");
            QueHacer QueHacer2 = new QueHacer(new DateTime(2018, 2, 2, 8, 40, 00), "Tarea Restas", "ejecuta una sustraccion entre dos elementos");
            QueHacer QueHacer3 = new QueHacer(new DateTime(2018, 2, 3, 10, 20, 00), "Tarea Multiplicaciones", "ejecuta un producto entre dos elementos");
            QueHacer QueHacer4 = new QueHacer(new DateTime(2018, 2, 4, 13, 00, 00), "Tarea Divisiones", "ejecuta un cociente entre dos elementos");
            QueHacer QueHacer5 = new QueHacer(new DateTime(2018, 2, 5, 8, 20, 00), "Tarea Exponentes" , "ejecuta una potencia entre dos elementos");
            QueHacer QueHacer6 = new QueHacer(new DateTime(2018, 2, 6, 12, 00, 00), "Tarea Radicales", "ejecuta una raíz entre dos elementos");
        
            Persona1.AgregarQueHacer(QueHacer2);
            Persona1.AgregarQueHacer(QueHacer4);
            Persona1.AgregarQueHacer(QueHacer6);

            Persona2.AgregarQueHacer(QueHacer1);
            Persona2.AgregarQueHacer(QueHacer3);
            Persona2.AgregarQueHacer(QueHacer5);

            Persona1.CompletarQueHacer();

            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();

            Console.WriteLine("(p1) {0} {1} esta disponible? {2}", Persona1.Nombre, Persona1.Apellido, Persona1.EstaDisponible());
            Console.WriteLine("(p2) {0} {1} esta disponible? {2}", Persona2.Nombre, Persona2.Apellido, Persona2.EstaDisponible());
            Console.ReadLine();

        }
    }
}
