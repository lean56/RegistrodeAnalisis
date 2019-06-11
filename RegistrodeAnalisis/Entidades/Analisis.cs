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
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<AnalisisDetalle> Detalles { get; set; }


        public Analisis()
        {
            AnalisisId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;

            Detalles = new List<AnalisisDetalle>();
        }
    }
}
