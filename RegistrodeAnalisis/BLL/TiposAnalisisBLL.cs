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
   public class TiposAnalisisBLL
    {
        public static bool Guardar(TiposAnalisis tiposAnalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
           
            try
            {
                if (db.TipoAnalisi.Add(tiposAnalisis) != null)
                    paso = db.SaveChanges() > 0;
                paso = true;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(TiposAnalisis tiposAnalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(tiposAnalisis).State = EntityState.Modified;
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
                var eliminar = db.TipoAnalisi.Find(id);
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

        public static TiposAnalisis Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TiposAnalisis tiposAnalisis = new TiposAnalisis();

            try
            {
                tiposAnalisis = contexto.TipoAnalisi.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tiposAnalisis;
        }

        public static List<TiposAnalisis> GetList(Expression<Func<TiposAnalisis, bool>> tipoAnalisis)
        {
            List<TiposAnalisis> Lista = new List<TiposAnalisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.TipoAnalisi.Where(tipoAnalisis).ToList();
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
