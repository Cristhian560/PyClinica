using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBack.entidades
{
    public class Paciente:Persona
    {
        public int Id { get; set; }
        public string ObraSocial { get; set; }
    }
}
