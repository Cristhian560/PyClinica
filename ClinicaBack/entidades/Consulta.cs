using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBack.entidades
{
    public class Consulta
    {
        public DateTime Fecha{ get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public string Estado { get; set; }
        public string Resultado { get; set; }
        public Consulta()
        {
            Estado = "Sin atender";
        }

        public static explicit operator Consulta(Turno turno)
        {
            Consulta temp = new Consulta()
            {
                Paciente = turno.Paciente,
            };
            return temp;
        }
    }
}
