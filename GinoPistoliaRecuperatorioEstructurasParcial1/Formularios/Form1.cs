using GinoPistoliaRecuperatorioEstructurasParcial1.Clases;
using GinoPistoliaRecuperatorioEstructurasParcial1.Formularios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinoPistoliaRecuperatorioEstructurasParcial1
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();

        private FormClinica formClinica = new FormClinica();
        private FormGuardia formGuardia = new FormGuardia();
        private FormPediatria formPediatria = new FormPediatria();


        public Form1()
        {
            InitializeComponent();
            Restaurar();
            formClinica.Show();
            formGuardia.Show();
            formPediatria.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione una especialidad",
                    "Advertencia: Registro de turnos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }
            string Especialidad = cmbEspecialidad.Text;

            cola.Insertar(txtDNI.Text, txtApellido.Text, txtNombre.Text, Especialidad);

            Backup();
            Actualizar(Especialidad);
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;


        }

        public void Actualizar(string Especialidad)
        {
            ListBox lista = null;

            switch (Especialidad)
            {
                case "Clínica":
                    lista = listClinica;
                    break;
                case "Guardia":
                    lista = listGuardia;
                    break;
                case "Pediatría":
                    lista = listPediatria;
                    break;
            }

            if (lista != null)
            {
                lista.Items.Clear();
                List<Paciente> pacientes = cola.CrearListaPorEspecialidad(Especialidad);

                foreach (Paciente paciente in pacientes)
                {
                    lista.Items.Add($"(DNI: {paciente.DNI}), {paciente.Apellido}, {paciente.Nombre}");
                }
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedItem != null)
            {
                string especialidad = cmbEspecialidad.Text;
                Actualizar(especialidad);
            }
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string especialidad;

            if (optClinica.Checked) especialidad = "Clínica";
            else if (optPediatria.Checked) especialidad = "Pediatría";
            else if (optGuardia.Checked) especialidad = "Guardia";
            else
            {
                MessageBox.Show(
                    "Por favor seleccione una especialidad",
                    "Advertencia: Registro de turnos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            Paciente pacienteLlamado = cola.LlamarSiguiente(especialidad);

            if (pacienteLlamado != null)
            {
                switch (especialidad)
                {
                    case "Clínica":
                        formClinica.MostrarPacienteActual(pacienteLlamado);
                        formClinica.MostrarSiguientePaciente(cola.VerSiguiente("Clínica"));
                        break;
                    case "Guardia":
                        formGuardia.MostrarPacienteActual(pacienteLlamado);
                        formGuardia.MostrarSiguientePaciente(cola.VerSiguiente("Guardia"));
                        break;
                    case "Pediatría":
                        formPediatria.MostrarPacienteActual(pacienteLlamado);
                        formPediatria.MostrarSiguientePaciente(cola.VerSiguiente("Pediatría"));
                        break;
                }

                Backup();
                Actualizar(especialidad);
            }
            else
            {
                MessageBox.Show(
                    "No hay más pacientes para " + especialidad,
                    "Atención de pacientes: Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }


        public void Backup()
        {
           
            List<string> lista = cola.ObtenerListaDeDatos();
            using (StreamWriter writer = File.CreateText("turnos_backup.txt"))
            {
               foreach (string paciente in lista)
               {
               writer.WriteLine(paciente);
               }
            }
            

        }

        public void Restaurar()
        {
            if (File.Exists("turnos_backup.txt"))
            {
                cola = new Cola();

                using (StreamReader read = new StreamReader("turnos_backup.txt"))
                {
                    string filaPaciente;
                    while ((filaPaciente = read.ReadLine()) != null)
                    {
                        string[] campos = filaPaciente.Split(',');
                        cola.Insertar(campos[0], campos[1], campos[2], campos[3]);
                    }
                }

                Actualizar("Clínica");
                Actualizar("Guardia");
                Actualizar("Pediatría");
                ActualizarPantallas();
            }
        }
            

      

        private void ActualizarPantallas()
        {
            List<Paciente> pacientesClinica = cola.CrearListaPorEspecialidad("Clínica");
            if (pacientesClinica.Count > 0)
            {
                formClinica.MostrarPacienteActual(pacientesClinica[0]);

                if (pacientesClinica.Count > 1)
                {
                    formClinica.MostrarSiguientePaciente(pacientesClinica[1]);
                }
                else
                {
                    formClinica.MostrarSiguientePaciente(null);
                }
            }

            List<Paciente> pacientesGuardia = cola.CrearListaPorEspecialidad("Guardia");
            if (pacientesGuardia.Count > 0)
            {
                formGuardia.MostrarPacienteActual(pacientesGuardia[0]);

                if (pacientesGuardia.Count > 1)
                {
                    formGuardia.MostrarSiguientePaciente(pacientesGuardia[1]);
                }
                else
                {
                    formGuardia.MostrarSiguientePaciente(null);
                }
            }

            List<Paciente> pacientesPediatria = cola.CrearListaPorEspecialidad("Pediatria");
            if (pacientesPediatria.Count > 0)
            {
                formPediatria.MostrarPacienteActual(pacientesPediatria[0]);

                if (pacientesPediatria.Count > 1)
                {
                    formPediatria.MostrarSiguientePaciente(pacientesPediatria[1]);
                }
                else
                {
                    formPediatria.MostrarSiguientePaciente(null);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                cola.CancelarTurno(txtDNI.Text);
                Backup();
                Actualizar("Clínica");
                Actualizar("Pediatría");
                Actualizar("Guardia");

                MessageBox.Show(
                    "¡Turno cancelado exitosamente!",
                    "Cancelación de turno: Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }
    }
}
