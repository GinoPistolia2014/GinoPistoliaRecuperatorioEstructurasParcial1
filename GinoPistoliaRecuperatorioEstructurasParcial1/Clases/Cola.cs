using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinoPistoliaRecuperatorioEstructurasParcial1.Clases
{
    public class Cola
    {
        public Paciente Inicio; 
        public Paciente Fin;

        public Cola() 
        {
            Inicio = null;
            Fin = null;
        }

        public void Insertar(string DNI, string Apellido, string Nombre, string Especialidad)
        {
            Paciente paciente = new Paciente(DNI, Apellido, Nombre, Especialidad);

            if (Inicio == null)
            {
                Inicio = paciente;
                Fin = paciente;
            }
            else
            {
                Fin.Siguiente = paciente;
                Fin = paciente;
            }

        }
        public Paciente Eliminar()
        {
            if (Inicio != null)
            {
                Paciente auxiliar = Inicio;
                Inicio = auxiliar.Siguiente;

                if (Inicio == null) Fin = null;

                auxiliar.Siguiente = null;
                return auxiliar;
            }
            return null;
        }

        public List<Paciente> CrearListaPorEspecialidad(string especialidad)
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente actual = Inicio;

            while (actual != null)
            {
                if (actual.Especialidad == especialidad)
                {
                    pacientes.Add(actual);
                }
                actual = actual.Siguiente;
            }

            return pacientes;
        }

        public Paciente LlamarSiguiente(string especialidad)
        {
            if (Inicio == null) return null;

            Paciente actual = Inicio;
            Paciente anterior = null;

            while (actual != null && actual.Especialidad != especialidad)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null) return null;

            if (anterior == null)
            {
                Inicio = actual.Siguiente;
            }
            else
            {
                anterior.Siguiente = actual.Siguiente;
            }

            if (actual == Fin)
            {
                Fin = anterior;
            }

            actual.Siguiente = null;
            return actual;
        }

        public Paciente VerSiguiente(string especialidad)
        {
            Paciente actual = Inicio;

            while (actual != null)
            {
                if (actual.Especialidad == especialidad)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public List<string> ObtenerListaDeDatos()
        {
            List<string> lista = new List<string>();
            Paciente auxiliar = Inicio;

            while (auxiliar != null)
            {
                lista.Add($"{auxiliar.DNI},{auxiliar.Apellido},{auxiliar.Nombre},{auxiliar.Especialidad}");
                auxiliar = auxiliar.Siguiente;
            }
            return lista;
        }

        public void CancelarTurno(string DNI)
        {
            Cola colaAuxiliar = new Cola();
            while (Inicio != null)
            {
                Paciente eliminado = this.Eliminar();

                if (eliminado != null && eliminado.DNI != DNI)
                {
                    colaAuxiliar.Insertar(eliminado.DNI, eliminado.Apellido, eliminado.Nombre, eliminado.Especialidad);
                }
            }
            this.Inicio = colaAuxiliar.Inicio;
            this.Fin = colaAuxiliar.Fin;
        }

    }
}
