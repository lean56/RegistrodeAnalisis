using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeAnalisis.Entidades
{
  public class AnalisisDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AnalisisId { get; set; }
        public string TipoAnalisis { get; set; }
        public string Resultado { get; set; }

        public AnalisisDetalle()
        {
            Id = 0;
            AnalisisId = 0;
            TipoAnalisis = string.Empty;
            Resultado = string.Empty;
        }

        public AnalisisDetalle(int id, int analisisId, string tipoAnalisis,string resultado)
        {
            Id = id;
            AnalisisId = analisisId;
            TipoAnalisis = tipoAnalisis;
            Resultado = resultado;
        }
    }
}
