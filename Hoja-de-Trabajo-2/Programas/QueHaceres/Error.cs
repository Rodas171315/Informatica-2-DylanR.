using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueHaceres
{
    class Error
    {
       public static void main(string[] args)
       {
            Persona turing = new Persona("Alan", "Turing");
            Persona alonzo = new Persona("Alonzo", "Church");

            QueHacer deber1 = new QueHacer(new DateTime(), "x", "Inventar las ciencias de la computacion.");        
            turing.AgregarQueHacer(deber1);
            alonzo.AgregarQueHacer(deber1); 

            turing.CompletarQueHacer();

            Console.WriteLine("Estara disponible Alonzo?");
            Console.WriteLine(alonzo.EstaDisponible() ? "Si" : "No");
            Console.ReadLine();
        }
    }
}