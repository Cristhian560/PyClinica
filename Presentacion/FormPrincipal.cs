
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
    public partial class FormPrincipal : Form
    {
        private Form activeForm = null;
        public FormPrincipal( )
        {
            InitializeComponent();
            panelTurnos.Visible = false;
            panelListaPacientes.Visible = false;
            panelMedicos.Visible = false;
            Form formInicio = new FormInicio();
            AbrirForm(formInicio);
        }
        /// <summary>
        /// Oculta todos los paneles(subMenus) que estan visibles
        /// </summary>
        private void OcultarSubmenu()
        {
            if (panelTurnos.Visible == true)
                panelTurnos.Visible = false;
            if (panelListaPacientes.Visible == true)
                panelListaPacientes.Visible = false;
            if (panelMedicos.Visible == true)
                panelMedicos.Visible = false;
        }
        /// <summary>
        /// Pone visible el panel(subMenu) que pasamos como parametro
        /// </summary>
        /// <param name="submenu">panel(subMenu) a mostrar</param>
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        /// <summary>
        /// Muestra el formulario recibido como parametro en el Panel Principal y cierra el que estaba abierto
        /// </summary>
        /// <param name="form">Formulario a abrir</param>
        private void AbrirForm(Form form)
        {
            if (activeForm!=null) 
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.Show();
        }
        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            Form formRecepcion = new FormRecepcion();
            AbrirForm(formRecepcion);
        }

        private void btnListaEspera_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            Form formListaEspera = new FormListaDeEspera();
            AbrirForm(formListaEspera);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            Form formListaMedicos = new FormListaMedicos();
            AbrirForm(formListaMedicos);
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Form formEstadisticas = new FormEstadistica();
            AbrirForm(formEstadisticas);
        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelTurnos);
        }
        private void btnListaDePacientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelListaPacientes);
        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMedicos);
        }
        /// <summary>
        /// Boton salir, muestra un ventana de dialogo preguntando si desea salir de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
