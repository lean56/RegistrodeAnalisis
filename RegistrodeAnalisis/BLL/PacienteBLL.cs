using RegistrodeAnalisis.DAL;
using RegistrodeAnalisis.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeAnalisis.BLL
{
   public class PacienteBLL
    {
        public static bool Guardar(Paciente paciente)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Paciente.Add(paciente) != null)
                    paso = db.SaveChanges() > 0;
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Paciente paciente)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(paciente).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Paciente.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Paciente Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Paciente paciente = new Paciente();

            try
            {
                paciente = contexto.Paciente.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paciente;
        }

        public static List<Paciente> GetList(Expression<Func<Paciente, bool>> paciente)
        {
            List<Paciente> Lista = new List<Paciente>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Paciente.Where(paciente).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
