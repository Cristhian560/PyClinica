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
    public partial class FormRecepcion : Form
    {
        private Queue<Turno> turnos;
        private Queue<Consulta> consultas;
        private List<Medico> medicos;
        private Stack<Turno> lista_recepcion;
        private List<Turno> lista_temp;
        private List<Turno> lista_temp_turnos;
        public FormRecepcion()
        {
            InitializeComponent();
            lista_recepcion = new Stack<Turno>();

            turnos = Clinica.Instancia().GetTurnos();
            medicos = Clinica.Instancia().GetMedicos();
            consultas = Clinica.Instancia().GetConsultas();
        }
        private void FormListaDePacientes_Load(object sender, EventArgs e)
        {
            CargarListaRecepcion();
            ActualizarGrilla();
            CargarCombos();

            if (Clinica.Instancia().DatosHardcodeados())
            {
                btnTurnosHardcodeados.Enabled = false;
            }
        }
        /// <summary>
        /// Elimina la consulta que coincida con el dni y especialidad pasados como parametro
        /// </summary>
        /// <param name="dni">dni de la consulta a eliminar</param>
        /// <param name="especialidad">especialidad de la consulta a eliminar</param>
        private void EliminarConsulta(int dni, string especialidad)
        {
            List<Consulta> lista_temp_consultas = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                lista_temp_consultas.Add(consulta);
            }
            foreach (Consulta consulta1 in lista_temp_consultas)
            {
                if (consulta1.Paciente.Dni == dni && consulta1.Medico.Especialidad == especialidad)
                {
                    lista_temp_consultas.Remove(consulta1);
                    break;
                }
            }
            consultas.Clear();
            foreach (Consulta consulta2 in lista_temp_consultas)
            {
                consultas.Enqueue(consulta2);
            }
        }
        /// <summary>
        /// Elimina un turno de la lista turnos que corresponda al dni y especialidad pasados como parametro
        /// </summary>
        /// <param name="dni">dni del turno a borrar</param>
        /// <param name="especialidad">especialidad del turno a borrar</param>
        private void EliminarTurno(int dni,string especialidad)
        {
            lista_temp_turnos = new List<Turno>();
            foreach (Turno turno in turnos)
            {
                lista_temp_turnos.Add(turno);
            }
            foreach (Turno turno1 in lista_temp_turnos)
            {
                if(turno1.Paciente.Dni == dni && turno1.Especialidad == especialidad)
                {
                    lista_temp_turnos.Remove(turno1);
                    break;
                }
            }
            turnos.Clear();
            foreach (Turno turno2 in lista_temp_turnos)
            {
                turnos.Enqueue(turno2);
            }
        }
        /// <summary>
        /// Elimina el turno selecionado de la grilla y de la lista lista_recepcion
        /// </summary>
        /// <returns>
        /// true : si se elimino el turno
        /// false : si no se elimino el turno, (no se p)
        /// </returns>
        private bool EliminarTurnoRecepcion()
        {
            bool i = false;
            if (VerificarEstado())
            {
                lista_temp = new List<Turno>();
                foreach (Turno turno in lista_recepcion)
                {
                    lista_temp.Add(turno);
                }
                foreach (Turno turno1 in lista_temp)
                {
                    if (turno1.Paciente.Dni == Convert.ToInt32(dgvListaRecepcion.CurrentRow.Cells[3].Value)&&turno1.Especialidad== dgvListaRecepcion.CurrentRow.Cells[6].Value.ToString())
                    {
                        lista_temp.Remove(turno1);
                        EliminarTurno(turno1.Paciente.Dni,turno1.Especialidad);
                        EliminarConsulta(turno1.Paciente.Dni, turno1.Especialidad);
                        break;
                    }
                }
                lista_recepcion.Clear();
                foreach (Turno turno2 in lista_temp)
                {
                    lista_recepcion.Push(turno2);
                }
                CargarListaRecepcion();
                ActualizarGrilla();
                i = true;
            }
            return i;
        }
        /// <summary>
        /// Carga Pacientes Hardcodeados
        /// </summary>
        private void CargarTurnos()
        {
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Mario", Apellido = "Gonzales", Dni = 45123100, Edad = 25, ObraSocial = "NoTiene" }, Especialidad = "Odontologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Carla", Apellido = "Flores", Dni = 45123101, Edad = 35, ObraSocial = "NoTiene" }, Especialidad = "Cardiologia", });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Claudio", Apellido = "Castillo", Dni = 45123102, Edad = 24, ObraSocial = "NoTiene" }, Especialidad = "Endocrinologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Carlos", Apellido = "Gomez", Dni = 45123103, Edad = 41, ObraSocial = "NoTiene" }, Especialidad = "Epidemiologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Monica", Apellido = "Constancio", Dni = 45123104, Edad = 15, ObraSocial = "NoTiene" }, Especialidad = "Geriatria" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Graciela", Apellido = "Rodriguez", Dni = 45123105, Edad = 52, ObraSocial = "NoTiene" }, Especialidad = "Gastroenterologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Camila", Apellido = "Martinez", Dni = 45123106, Edad = 16, ObraSocial = "NoTiene" }, Especialidad = "Infectologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Karen", Apellido = "Caminos", Dni = 45123107, Edad = 30, ObraSocial = "NoTiene" }, Especialidad = "Infectologia" });
            Clinica.Instancia().AgregarTurno(new Turno { Paciente = new Paciente { Nombre = "Eric", Apellido = "Romero", Dni = 45123108, Edad = 60, ObraSocial = "NoTiene" }, Especialidad = "Urologia" });
            ActualizarGrilla();
        }
        /// <summary>
        /// Carga los ComboBox Especialidades y Obras Sociales
        /// </summary>
        private void CargarCombos()
        {
            cboObraSocial.DataSource = Enum.GetValues(typeof(EnumObraSocial));
            cboObraSocial.SelectedIndex = -1;
            cboEspecialidad.DataSource = Enum.GetValues(typeof(EnumEspecialidades));
            cboEspecialidad.SelectedIndex = -1;
        }
        /// <summary>
        /// Pasa los elementos de la lista turnos a lista_recepcion con el objetivo que primero se muestren los turnos recientemente asignados
        /// </summary>
        private void CargarListaRecepcion()
        {
            lista_recepcion.Clear();
            foreach (Turno turno in turnos)
            {
                if (VerificarEstado(turno))
                {
                    lista_recepcion.Push(turno);
                }
            }
        }

        /// <summary>
        /// Carga la grilla con los turnos
        /// </summary>
        private void ActualizarGrilla()
        {
            dgvListaRecepcion.Rows.Clear();
            foreach (Turno turno in lista_recepcion)
            {
                dgvListaRecepcion.Rows.Add(new object[] { turno.Paciente.Id, turno.Paciente.Nombre, turno.Paciente.Apellido, turno.Paciente.Dni, turno.Paciente.ObraSocial, turno.Paciente.Edad, turno.Especialidad });
            }
            dgvListaRecepcion.CurrentCell = null;
        }
        /// <summary>
        /// Agrega un turno a la lista turnos,lista_recepcion,consultas si la persona no tiene ya asignado un turno para esa especialidad
        /// si ya tiene un turno para esa especialidad, el turno no se guarda y muestra un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                if (ComprobarSeleccionCombos())
                {
                    if (!ComprobarEspecialidadTurnoPaciente())
                    {
                        Paciente paciente = new Paciente()
                        {
                            Id = 0,
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Edad = Convert.ToInt32(txtEdad.Text),
                            Dni = Convert.ToInt32(txtDni.Text),
                            ObraSocial = cboObraSocial.Text
                        };
                        Turno turno = new Turno()
                        {
                            Paciente = paciente,
                            Especialidad = cboEspecialidad.Text
                        };
                        Clinica.Instancia().AgregarTurno(turno);
                        lista_recepcion.Push(turno);
                        consultas.Enqueue(ConvertirAConsulta(turno));
                        ActualizarGrilla();
                        LimpiaTxtboxAndCampos();
                    }
                    else
                    {
                        MessageBox.Show("Este paciente ya tiene un turno para la especialidad : "+cboEspecialidad.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }
        /// <summary>
        /// Comprueba que se haya elejido una opcion de los ComboBoxs
        /// </summary>
        /// <returns>
        /// true : si se selecciono alguna opcion de los combobox
        /// false : si no se seleciono ninguna opcion de los combobox o si solo se selecciono una opcion de uno solo
        /// </returns>
        private bool ComprobarSeleccionCombos()
        {
            bool i = false;
            if (cboEspecialidad.SelectedIndex == -1 && cboObraSocial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opcion de Obra Social y Especialidad");
                
            }
            else if (cboEspecialidad.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una especialidad");
            }
            else if(cboObraSocial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opcion de Obra Social");
            }
            else
            {
                i = true;
            }
            return i;
        }

        /// <summary>
        /// Limpia todos los campos del formulario y cambia la seleccion de los Combobox a ninguno
        /// </summary>
        private void LimpiaTxtboxAndCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
            cboEspecialidad.SelectedIndex = -1;
            cboObraSocial.SelectedIndex = -1;
        }
        /// <summary>
        /// Comprueba que los campos no esten vacios
        /// </summary>
        /// <returns>
        /// true : si los campos tienen datos
        /// false : si los campos estan vacios
        /// </returns>
        private bool ComprobarDatos()
        {
            bool i = false;
            if(!(txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtEdad.Text == ""))
            {
                i = true;
            }
            return i;
        }
        /// <summary>
        /// Comprueba si el Dni ingresado ya esta en la lista de recepcion
        /// </summary>
        /// <returns>
        /// true : si ya hay un turno con un pacientecon ese dni
        /// false : si aun no sea ingresado un turno con es dni
        /// </returns>
        private bool ComprobarEspecialidadTurnoPaciente()
        {
            bool i = false;
            foreach (Turno turno in lista_recepcion)
            {
                if (turno.Paciente.Dni==Convert.ToInt32(txtDni.Text)&& turno.Especialidad == cboEspecialidad.Text)
                {
                    i = true;
                }
            }
            return i;
        }

        /// <summary>
        /// Convierte la lista de turnos en una lista de consultas, solo se usa este metodo cuando se carga la 
        /// lista hardcodeada de pacientes
        /// </summary>
        private void ConstruirListaConsultas()
        {
            Clinica.Instancia().VaciarListaConsultas();
            
            foreach (Turno turno in turnos)
            {
                Consulta consulta = new Consulta();
                consulta = (Consulta)turno;
                foreach (Medico medico in medicos)
                {
                    if (turno.Especialidad == medico.Especialidad)
                    {
                        consulta.Medico = medico;
                    }
                }
                consultas.Enqueue(consulta);
            }
        }
        /// <summary>
        /// Convierte un Turno en una Consulta
        /// </summary>
        /// <param name="turno"></param>
        /// <returns>turno convertido a consulta, con la propiedad Medico cargada de acuerdo a la especialidad solicitada en el turno /returns>
        private Consulta ConvertirAConsulta(Turno turno)
        {
            Consulta consulta = new Consulta();
            consulta = (Consulta)turno;
            foreach (Medico medico in medicos)
            {
                if (turno.Especialidad == medico.Especialidad)
                {
                    consulta.Medico = medico;
                }
            }
            return consulta;
        }
        /// <summary>
        /// Limpia la grilla y va mostrando las conincidencias del dni que se va ingresando
        /// el txtFiltro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dgvListaRecepcion.Rows.Clear();
                foreach (Turno turno in lista_recepcion)
                {
                    bool x = turno.Paciente.Dni.ToString().Contains(txtFiltro.Text.ToString());
                    if (x)
                    {
                         dgvListaRecepcion.Rows.Add(new object[] { turno.Paciente.Id, turno.Paciente.Nombre, turno.Paciente.Apellido, turno.Paciente.Dni, turno.Paciente.ObraSocial, turno.Paciente.Edad, turno.Especialidad });
                    }
                }
                dgvListaRecepcion.CurrentCell = null;
            }
            else
            {
                ActualizarGrilla();
            }
        }
        /// <summary>
        /// inhabilita el boton TurnosHardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurnosHardcodeados_Click(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarListaRecepcion();
            ActualizarGrilla();
            ConstruirListaConsultas();
            btnTurnosHardcodeados.Enabled = false;
            dgvListaRecepcion.CurrentCell = null;
            Clinica.Instancia().CambiarEstadoDatosHardcodeados();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            ComprobarTextBox(txtEdad,"Edad");
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            ComprobarTextBox(txtDni,"Dni");
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ComprobarTextBox(txtNombre,"Nombre");
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ComprobarTextBox(txtApellido, "Apellido");
        }
        /// <summary>
        /// Comprueba que el parametro que recibe sea un numero
        /// </summary>
        /// <param name="campo">valor a comprobar</param>
        /// <returns>
        /// true : si el parametro es un numero
        /// false : si el parametro no es un numero, contiene letras o es algun simbolo
        /// </returns>
        private bool IsNumber(string campo)
        {
            bool b = false;
            if (campo != "")
            {
                for (int i = 0; i < campo.Length; i++)
                {
                    if (Char.IsDigit(campo, i))
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            else
            {
                b = true;
            }
            return b;
        }
        /// <summary>
        /// Muestra un mensaje(ventana modal) si se intenta ingresar numeros en el textbox Nombre y Apellido,
        /// tambien Muestra un mensaje(ventana modal) si se intenta ingresar letras en el textbox Edad y Dni
        /// </summary>
        /// <param name="textBox">cualquier textbox del formulario</param>
        /// <param name="nombre_textbox">nombre del texbox sin txt</param>
        private void ComprobarTextBox(TextBox textBox,string nombre_textbox)
        {
            if (textBox.Text!="")
            {
                if (IsNumber(textBox.Text) )
                {
                    if (nombre_textbox == "Nombre" || nombre_textbox == "Apellido")
                    {
                        MessageBox.Show(nombre_textbox + " Incorreto");
                        textBox.Text = "";
                    }
                }
                else
                {
                    if (nombre_textbox == "Edad" || nombre_textbox == "Dni")
                    {
                        MessageBox.Show(nombre_textbox + " Incorreto");
                        textBox.Text = "";
                    }
                }
            }
        }
        /// <summary>
        /// Evento click en Boton Eliminar de la grillas: muestra un mensaje preguntando si desea eliminar el turno seleccionado en la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaRecepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaRecepcion.CurrentCell.ColumnIndex == 7) 
            {
                if (MessageBox.Show("Seguro que desea eliminar este turno ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (!EliminarTurnoRecepcion())
                    {
                        MessageBox.Show("Este turno no se puede eliminar por que este paciente ya fue atendido");
                    }
                }
            }
        }
        /// <summary>
        /// Verifica si un turno ya fue atendido
        /// </summary>
        /// <param name="turno"></param>
        /// <returns>
        /// true : si el todavia no fue atendido
        /// false : si ya fue atendido
        /// </returns>
        private bool VerificarEstado()
        {
            bool i = true;
            foreach (Consulta consulta in consultas)
            {
                if (consulta.Paciente.Dni== Convert.ToInt32(dgvListaRecepcion.CurrentRow.Cells[3].Value) && consulta.Estado== "Atendido" && consulta.Medico.Especialidad== dgvListaRecepcion.CurrentRow.Cells[3].Value.ToString())
                {
                    i = false;
                    break;
                }
            }
            return i;
        }
        /// <summary>
        /// Verifica si el turno pasado como parametro ya fue atendido
        /// </summary>
        /// <param name="turno"></param>
        /// <returns>
        /// true : si el todavia no fue atendido
        /// false : si ya fue atendido
        /// </returns>
        private bool VerificarEstado(Turno turno)
        {
            bool i = true;
            foreach (Consulta consulta in consultas)
            {
                if (turno.Paciente.Dni == consulta.Paciente.Dni && consulta.Estado == "Atendido" && turno.Especialidad==consulta.Medico.Especialidad)
                {
                    i = false;
                    break;
                }
            }
            return i;
        }
    }
}
