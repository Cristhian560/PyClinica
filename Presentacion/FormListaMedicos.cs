using ClinicaBack.entidades;
using ClinicaBack;
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
    public partial class FormListaMedicos : Form
    {
        public FormListaMedicos()
        {
            InitializeComponent();
        }

        private void FormListaMedicos_Load(object sender, EventArgs e)
        {
            CargarGrillaMedicos();
        }
        /// <summary>
        /// Carga la lista de medicos
        /// </summary>
        private void CargarGrillaMedicos()
        {
            foreach (Medico medico in Clinica.Instancia().GetMedicos())
            {
                dgvMedicos.Rows.Add(new object[] { medico.Nombre, medico.Apellido, medico.Especialidad, medico.Disponible });
            }
            dgvMedicos.CurrentCell = null;
        }
    }
}
