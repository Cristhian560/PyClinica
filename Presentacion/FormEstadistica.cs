using ClinicaBack;
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
    public partial class FormEstadistica : Form
    {
        private List<Dato> datos;
        public FormEstadistica()
        {
            InitializeComponent();
            datos = new List<Dato>();
        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {
            CreaListaDatos();
            CargarGrilla();
        }
        /// <summary>
        /// Convierte una Consulta en Tipo Dato e incrementa en 1 la propiedad PacientesAtendidos
        /// </summary>
        /// <param name="consulta">instancia de Clase Consulta a convertir</param>
        /// <returns>Consulta convertida en Tipo Dato</returns>
        private Dato ConvertirADato(Consulta consulta)
        {
            Dato dato = new Dato();
            dato = (Dato)consulta;
            dato.PacientesAtendidos += 1;
            return dato;
        }
        /// <summary>
        /// Agrega elementos a la lista datos, solo se agregan aquellos cuya especialidad no este agregada, si ya existe 
        /// un elemento con esa especialidad solo se incremente en uno la propiedad PacientesAtendidos
        /// </summary>
        private void CreaListaDatos()
        {
            foreach (Consulta consulta in Clinica.Instancia().GetHistorialConsultas())
            {
                if (datos.Count==0)
                {
                    datos.Add(ConvertirADato(consulta));
                }
                else
                {
                    bool x = false;
                    foreach (Dato d in datos)
                    {
                        if (consulta.Medico.Especialidad == d.Consulta.Medico.Especialidad)
                        {
                            d.PacientesAtendidos += 1;
                            x = true;
                        }
                    }
                    if (!x)
                    {
                        datos.Add(ConvertirADato(consulta));
                    }
                }
            }
        }
        /// <summary>
        /// Carga una grilla con los medicos ordenados por cantidad de pacientes en forma decendiente y 
        /// Muestra el nombre y apellido del medico que mas pacientes atendio y tambien el medico que menos pacientes atendio 
        /// </summary>
        private void CargarGrilla()
        {
            var listaPorCantidadPacientesAtendidos = (from cant in datos
                                                      orderby cant.PacientesAtendidos descending
                                                      select cant);

            int i = 0;
            if (listaPorCantidadPacientesAtendidos.Count() > 1 && ComprobarCantAtendidos())
            {
                foreach (Dato dato in listaPorCantidadPacientesAtendidos)
                {
                    if (i == 0)
                    {
                        lblMedicoMayorCantidadPacientes.Text = dato.Consulta.Medico.Nombre + " " + dato.Consulta.Medico.Apellido;
                    }
                    i++;
                    dgvCantidadPacientesAtendidos.Rows.Add(new object[] { dato.Consulta.Medico.Nombre, dato.Consulta.Medico.Apellido, dato.Consulta.Medico.Especialidad, dato.PacientesAtendidos });
                    if (i == listaPorCantidadPacientesAtendidos.Count())
                    {
                        lblMenorCantidadPacientes.Text = dato.Consulta.Medico.Nombre + " " + dato.Consulta.Medico.Apellido;
                    }
                }
                dgvCantidadPacientesAtendidos.CurrentCell = null;
            }
            else
            {
                foreach (Dato dato in listaPorCantidadPacientesAtendidos)
                {
                    dgvCantidadPacientesAtendidos.Rows.Add(new object[] { dato.Consulta.Medico.Nombre, dato.Consulta.Medico.Apellido, dato.Consulta.Medico.Especialidad, dato.PacientesAtendidos });
                }
                dgvCantidadPacientesAtendidos.CurrentCell = null;
            }
        }
        /// <summary>
        /// Comprueba que hayan mas de dos elementos en la lista datos y que las cantidades de PacientesAtendidos sean distintas, esto es
        /// para poder decir què medico atendio mas ò menos pacientes
        /// </summary>
        /// <returns>
        /// true : si la cantidad de pacientes atendidos por cada medico son distintas
        /// false : si la cantidad de pacintes atendidos por cada medico son iguales 
        /// </returns>
        private bool ComprobarCantAtendidos()
        {
            bool bandera=false;
            int cant = 0;
            int i = 1;

            foreach (Dato item in datos)
            {
                if (i == 1)
                {
                    cant = item.PacientesAtendidos;
                }
                if (cant != item.PacientesAtendidos)
                {
                    bandera = true;
                }
                i++;
            }
            return bandera;
        }
    }
}
