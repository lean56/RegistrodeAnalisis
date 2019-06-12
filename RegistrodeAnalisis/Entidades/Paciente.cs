using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeAnalisis.Entidades
{
   public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public Paciente()
        {
            PacienteId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Sexo = string.Empty;
            Edad = 0;
            Direccion = string.Empty;
        }
    }
}
