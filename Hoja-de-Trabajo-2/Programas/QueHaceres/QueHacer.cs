using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueHaceres
{
    public enum Estado
    {
        EnProgreso,
        Terminado
    }

    public class QueHacer
    {
        public DateTime Fecha { get; set; }
        public String Mision { get; set; }
        public String Objetivo { get; set; }
        public Estado Estado { get; private set; }
        
        public QueHacer(DateTime fecha, string mision, string objetivo)
        {
            this.Fecha = fecha;
            this.Mision = mision;
            this.Objetivo = objetivo;

            this.Estado = new Estado();
            this.Estado = Estado.EnProgreso;
        }

        public void Completar()
        {
            this.Estado = Estado.Terminado;
        }

    }
}