using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBack.entidades
{
    public class Dato
    {
        public int PacientesAtendidos { get; set; }
        public Consulta Consulta { get; set; }

        public static explicit operator Dato(Consulta consulta)
        {
            Dato temp = new Dato()
            {
                Consulta = consulta
            };
            return temp;
        }
    }
}
