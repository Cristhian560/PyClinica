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
    public partial class FormListaDeEspera : Form
    {
        private Queue<Consulta> consultas;
        private Queue<Turno> turnos;
        private List<Consulta> consultas_sin_atender;
        private List<Consulta> consultas_atendidas;
        private Stack<Consulta> historial_consultas_atendidas;
        private List<Medico> medicos;
        public FormListaDeEspera()
        {
            InitializeComponent();

            consultas_sin_atender = new List<Consulta>();
            consultas_atendidas = new List<Consulta>();

            historial_consultas_atendidas = Clinica.Instancia().GetHistorialConsultas();
            consultas = Clinica.Instancia().GetConsultas();
            medicos = Clinica.Instancia().GetMedicos();
            turnos = Clinica.Instancia().GetTurnos();
        }
        private void FormListaDeEspera_Load(object sender, EventArgs e)
        {
            CargarListas();
            ActualizarGrillas();
        }
        /// <summary>
        /// Actualiza las Grillas : Consultas_sin_atender y Consultas_atendidas 
        /// </summary>
        private void ActualizarGrillas()
        {
            dgvListaConsultaSinAtender.Rows.Clear();
            foreach (Consulta consulta in consultas_sin_atender)
            {
                dgvListaConsultaSinAtender.Rows.Add(new object[] { consulta.Paciente.Id, consulta.Paciente.Nombre, consulta.Paciente.Apellido, consulta.Paciente.Dni, consulta.Paciente.ObraSocial, consulta.Paciente.Edad, consulta.Medico.Especialidad });
            }
            dgvListaConsultaSinAtender.CurrentCell = null;


            dgvListaConsultaAtendidas.Rows.Clear();
            foreach (Consulta consulta in consultas_atendidas)
            {
                dgvListaConsultaAtendidas.Rows.Add(new object[] { consulta.Paciente.Id, consulta.Paciente.Nombre, consulta.Paciente.Apellido, consulta.Paciente.Dni, consulta.Paciente.ObraSocial, consulta.Paciente.Edad, consulta.Medico.Especialidad });
            }
            dgvListaConsultaAtendidas.CurrentCell = null;
        }
        /// <summary>
        /// Carga las listas consultas_sin_atender y consultas_atendidas con la lista consultas de acuerdo a ciertos criterios
        /// </summary>
        private void CargarListas()
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.Estado == "Sin atender")
                {
                    consultas_sin_atender.Add(consulta);
                }
                else if (consulta.Estado == "Atendido" && consulta.Resultado == "Consulta en progreso")
                {
                    consultas_atendidas.Add(consulta);
                }
            }
        }
        /// <summary>
        /// Evento click del boton iniciar consulta, se recorre la lista de medicos para saber si el medico de esa especialidad esta Disponible o no ,
        /// si esta disponible se puede iniciar la consulta, se cambia la propiedad del medico Disponible a "No", se cambia las propiedadades de la 
        /// consulta Estado a "Atendido" y Resultado a "Consulta en progreso" , se agrega la consulta a la lista consultas_atendidas 
        /// y se elimina de consultas_sin_atender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaEspera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaConsultaSinAtender.CurrentCell.ColumnIndex==7)
            {
                int dni_paciente = Convert.ToInt32(dgvListaConsultaSinAtender.CurrentRow.Cells[3].Value);
                if (!Comprobar(dni_paciente))
                {
                    foreach (Medico medico in medicos)
                    {
                        if (dgvListaConsultaSinAtender.CurrentRow.Cells[6].Value.ToString() == medico.Especialidad && medico.Disponible == "NO")
                        {
                            MessageBox.Show("EL MEDICO NO PUEDE ATENDER EN ESTE MOMENTO");
                            return;
                        }
                        if (dgvListaConsultaSinAtender.CurrentRow.Cells[6].Value.ToString() == medico.Especialidad && medico.Disponible == "SI")
                        {
                            if (MessageBox.Show("INICIAR CONSULTA?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                medico.Disponible = "NO";
                                foreach (Consulta consulta in consultas)
                                {

                                    if (consulta.Paciente.Dni == dni_paciente && consulta.Medico.Especialidad==medico.Especialidad )
                                    {
                                        consulta.Resultado = "Consulta en progreso";
                                        consulta.Estado = "Atendido";
                                        consultas_sin_atender.Remove(consulta);
                                        consultas_atendidas.Add(consulta);
                                        break;
                                    }
                                }
                                ActualizarGrillas();
                                return;
                            }
                        }
                    }
                }
                
            }
        }
        /// <summary>
        /// Comprobar que el paciente no este ya en una consulta, y muestra un mensaje si ya esta en una consulta
        /// </summary>
        /// <param name="dni_paciente">dni del paciente a comprobar si esta en una consulta</param>
        /// <returns>
        /// true : si el paciente ya esta en una consulta(consulta en progreso)
        /// false : si el paciente no esta en una consulta
        /// </returns>
        private bool Comprobar(int dni_paciente)
        {
            bool i = false;
            foreach (Consulta consulta in consultas)
            {
                if(consulta.Paciente.Dni==dni_paciente && consulta.Resultado== "Consulta en progreso")
                {
                    MessageBox.Show("Este paciente esta en una consulta en progreso");
                    i = true;
                    break;
                }
            }
            return i;
        }

        /// <summary>
        /// Evento click del boton Finalizar Consulta, muestra un mensaje si desea finalizar la consulta, si la respuesta es si : se cambia 
        /// la disponibilidad del medico a SI, luego se abre una ventana para con los datos de esa consulta en la cual debe agregar un resultado
        /// esta consulta se agrega a la lista de historial_consultas_atendidas y se elimina de consultas atendidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaConsultaAtendidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaConsultaAtendidas.CurrentCell.ColumnIndex == 7)
            {
                if (MessageBox.Show("FINALIZAR CONSULTA?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (Medico medico in medicos)
                    {
                        if (dgvListaConsultaAtendidas.CurrentRow.Cells[6].Value.ToString() == medico.Especialidad)
                        {
                            medico.Disponible = "SI";
                            foreach (Consulta consulta in consultas_atendidas)
                            {
                                if (consulta.Paciente.Dni == Convert.ToInt32(dgvListaConsultaAtendidas.CurrentRow.Cells[3].Value))
                                {
                                    Form formFinalizarConsulta = new FormFinalizarConsulta(consulta);
                                    formFinalizarConsulta.ShowDialog();

                                    historial_consultas_atendidas.Push(consulta);
                                    EliminarConsulta(consulta);
                                    EliminarTurno(consulta.Paciente.Dni,consulta.Medico.Especialidad);
                                    consultas_atendidas.Remove(consulta);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    ActualizarGrillas();
                }
            }
        }
        /// <summary>
        /// Elimina un turno de la lista turnos que corresponda al dni y especialidad pasados como parametro
        /// </summary>
        /// <param name="dni">dni del turno a borrar</param>
        /// <param name="especialidad">especialidad del turno a borrar</param>
        private void EliminarTurno(int dni, string especialidad)
        {
            List<Turno> lista_temp_turnos = new List<Turno>();
            foreach (Turno t in turnos)
            {
                lista_temp_turnos.Add(t);
            }
            foreach  (Turno turno in lista_temp_turnos)
            {
                if (turno.Paciente.Dni==dni && turno.Especialidad==especialidad)
                {
                    lista_temp_turnos.Remove(turno);
                    break;
                }
            }
            turnos.Clear();
            foreach (Turno t2 in lista_temp_turnos)
            {
                turnos.Enqueue(t2);
            }
        }
        /// <summary>
        /// Elimina la consulta pasada como parametro de la lista consultas
        /// </summary>
        /// <param name="consulta">consulta a eliminar</param>
        private void EliminarConsulta(Consulta consulta)
        {
            List<Consulta> lista_tem_consultas = new List<Consulta>();
            foreach (Consulta c in consultas)
            {
                lista_tem_consultas.Add(c);
            }
            lista_tem_consultas.Remove(consulta);
            consultas.Clear();
            foreach (Consulta c1 in lista_tem_consultas)
            {
                consultas.Enqueue(c1);
            }
        }
    }
}
