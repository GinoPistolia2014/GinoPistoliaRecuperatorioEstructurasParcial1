using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinoPistoliaRecuperatorioEstructurasParcial1.Clases
{
    public class Paciente
    {
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Paciente Siguiente;

        public Paciente(string DNI, string Apellido, string Nombre, string Especialidad)
        {
            this.DNI = DNI;
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Especialidad = Especialidad;
            this.Siguiente = null;
        }
    }
}
