using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeAnalisis.Entidades
{
   public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public int PacienteId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<AnalisisDetalle> DetallesAnalisis { get; set; }


        public Analisis()
        {
            AnalisisId = 0;
            PacienteId = 0; 
            DetallesAnalisis = new List<AnalisisDetalle>();
        }
    }
}
