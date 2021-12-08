using ClinicaBack.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBack
{
    public class Clinica
    {
        private Queue<Turno> turnos;
        private List<Medico> medicos;
        private Stack<Consulta> historial_consultas_atendidas;
        private Queue<Consulta> consultas;
        private bool datosHardcodeados;
        private static Clinica instancia;
        private Clinica()
        {
            datosHardcodeados = false;
            turnos = new Queue<Turno>();
            medicos = new List<Medico>();
            historial_consultas_atendidas = new Stack<Consulta>();
            consultas = new Queue<Consulta>();
            CargarMedicosHardCodeados();
        }
        /// <summary>
        /// Crea una instancia de la clase Clinica si esta no tiene ya una instancia,
        /// si ya se instancio antes devuelve la referencia de esa instancia.
        /// </summary>
        /// <returns></returns>
        public static Clinica Instancia()
        {
            if (instancia == null)
            {
                instancia = new Clinica();
            }
            return instancia;
        }
        /// <summary>
        /// Carga medicos HardCodeados a la lista medicos
        /// </summary>
        private void CargarMedicosHardCodeados()
        {
            medicos.Add(new Medico { Nombre = "Fabrizio", Apellido = "Leon", Especialidad = "Odontologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Marta", Apellido = "Quizpe", Especialidad = "Endocrinologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Melisa", Apellido = "Martinez", Especialidad = "Epidemiologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Sol", Apellido = "Connor", Especialidad = "Geriatria", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Claudio", Apellido = "Sosa", Especialidad = "Gastroenterologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Gabriel", Apellido = "Cortez", Especialidad = "Infectologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Fabio", Apellido = "Jordan", Especialidad = "Neurologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Maria", Apellido = "Solaris", Especialidad = "Oftalmologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Samuel", Apellido = "Jhonson", Especialidad = "Oncologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Juana", Apellido = "Rojo", Especialidad = "Psiquiatria", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Roberto", Apellido = "Flores", Especialidad = "Reumatologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Lucio", Apellido = "Velazques", Especialidad = "Urologia", Disponible = "SI" });
            medicos.Add(new Medico { Nombre = "Mariela", Apellido = "Bodenabe", Especialidad = "Cardiologia", Disponible = "SI" });
        }
        /// <summary>
        /// retorna una referencia a la lista historia_consultas_atendidas
        /// </summary>
        /// <returns>referencia a lista historial_consultas_atendidas</returns>
        public Stack<Consulta> GetHistorialConsultas()
        {
            return historial_consultas_atendidas;
        }
        /// <summary>
        /// Retorna una referencia a la lista consultas
        /// </summary>
        /// <returns>referencia a consultas</returns>
        public Queue<Consulta> GetConsultas()
        {
            return consultas;
        }
        /// <summary>
        /// Agrega turnos a la lista turnos
        /// </summary>
        /// <param name="turno">turno a gregar</param>
        public void AgregarTurno(Turno turno)
        {
            turnos.Enqueue(turno);
        }
        /// <summary>
        /// Retorna una referencia a la lista turnos
        /// </summary>
        /// <returns>referencia a turnos</returns>
        public Queue<Turno> GetTurnos()
        {
            return turnos;
        }
        /// <summary>
        /// Retorna una referencia a la lista medicos
        /// </summary>
        /// <returns>referencia a medicos</returns>
        public List<Medico> GetMedicos()
        {
            return medicos;
        }
        /// <summary>
        /// Borra todos los elementos de la lista consultas
        /// </summary>
        public void VaciarListaConsultas()
        {
            consultas.Clear() ;
        }
        /// <summary>
        /// Retorna una referncia a datosHardcodeados
        /// </summary>
        /// <returns>
        /// true : si se cargo la lista hardcodeada de turnos
        /// false : si no se cargo la lista hardcodeada de turnos
        /// </returns>
        public bool DatosHardcodeados()
        {
            return datosHardcodeados;
        }
        /// <summary>
        /// Cambia el estado de datoshardcodeados a true por que se cargaron los pacientes hardcodeados
        /// </summary>
        public void CambiarEstadoDatosHardcodeados()
        {
            datosHardcodeados = true;
        }
    }
}
