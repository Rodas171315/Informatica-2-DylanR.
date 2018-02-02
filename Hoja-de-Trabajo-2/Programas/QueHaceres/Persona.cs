using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueHaceres
{
    public class Persona
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public QueHaceres Tareas { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tareas = new QueHaceres();
        }

        public bool EstaDisponible() 
        {
            if (Tareas.EstaDisponible())
            {
                return true;
            }
            return false;
        }

        public void AgregarQueHacer(QueHacer QueHacer)
        {
            Tareas.AgregarTarea(QueHacer);
        }

        public void CompletarQueHacer()
        {
            Tareas.CompletarQueHacer();
        }

    }
}