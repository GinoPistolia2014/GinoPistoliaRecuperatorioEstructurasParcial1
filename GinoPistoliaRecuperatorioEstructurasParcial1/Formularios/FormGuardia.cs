using GinoPistoliaRecuperatorioEstructurasParcial1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinoPistoliaRecuperatorioEstructurasParcial1.Formularios
{
    public partial class FormGuardia : Form
    {
        public FormGuardia()
        {
            InitializeComponent();
            MostrarConsultorio();

        }

        public void MostrarConsultorio()
        {
            Random random = new Random();
            lblConsultorio.Text = "Gua" + random.Next(1, 5).ToString("000#");
        }

        public void MostrarPacienteActual(Paciente paciente)
        {
            lblNombre.Text = $"{paciente.Apellido.ToUpper()}, {paciente.Nombre}";
            lblDNI.Text = paciente.DNI;
        }

        public void MostrarSiguientePaciente(Paciente siguientePaciente)
        {
            listProximos.Items.Clear();

            if (siguientePaciente != null)
            {
                listProximos.Items.Add($"{siguientePaciente.DNI}, {siguientePaciente.Apellido}, {siguientePaciente.Nombre}");
            }
            else
            {
                listProximos.Items.Add("No hay pacientes en la Guardia");
            }
        }
    }
}
