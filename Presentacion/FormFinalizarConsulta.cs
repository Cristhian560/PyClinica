using ClinicaBack.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormFinalizarConsulta : Form
    {
        private Consulta consulta;
        public FormFinalizarConsulta(Consulta consulta)
        {
            InitializeComponent();
            this.consulta = consulta;
        }
        private void FormFinalizarConsulta_Load(object sender, EventArgs e)
        {
            //DATOS PACIENTE
            lblNombre.Text = consulta.Paciente.Nombre;
            lblApellido.Text = consulta.Paciente.Apellido;
            lblDni.Text = consulta.Paciente.Dni.ToString();
            lblEdad.Text = consulta.Paciente.Edad.ToString();
            lblObraSocial.Text = consulta.Paciente.ObraSocial;
            //DATOS MEDICO
            lblNombreMedico.Text = consulta.Medico.Nombre;
            lblApellidoMedico.Text = consulta.Medico.Apellido;
            lblEspecialidadMedico.Text = consulta.Medico.Especialidad;
        }
        /// <summary>
        /// Si el txtResultado esta vacio muestra un mensaje "DEBE AGREGAR UN RESULTADO", de lo contrario cambia el resultado de 
        /// la consulta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                MessageBox.Show("DEBE AGREGAR UN RESULTADO");
            }
            else
            {
                consulta.Resultado = txtResultado.Text;
                this.Dispose();
            }
        }
    }
}
