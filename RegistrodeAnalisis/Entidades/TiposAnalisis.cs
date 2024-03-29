﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeAnalisis.Entidades
{
   public class TiposAnalisis
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TiposAnalisis()
        {
            TipoId = 0;
            Descripcion = string.Empty;
        }

        public TiposAnalisis(int tipoId, string descripcion)
        {
            TipoId = tipoId;
            Descripcion = descripcion;
        }
    }
}
