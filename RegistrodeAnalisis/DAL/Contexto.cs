using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrodeAnalisis.Entidades;

namespace RegistrodeAnalisis.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Analisis> Analisi { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<TiposAnalisis> TipoAnalisi {get;set;}

        public Contexto() :base("Constr"){ }
    }
}
