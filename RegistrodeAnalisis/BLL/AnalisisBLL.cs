using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrodeAnalisis.Entidades;
using RegistrodeAnalisis.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistrodeAnalisis.BLL
{
   public class AnalisisBLL
    {
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Analisi.Add(analisis) != null)
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

        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(analisis).State = EntityState.Modified;
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
                var eliminar = db.Analisi.Find(id);
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

        public static Analisis Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Analisis analisis = new Analisis();

            try
            {
                analisis = contexto.Analisi.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return analisis;
        }

        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> analisis)
        {
            List<Analisis> Lista = new List<Analisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Analisi.Where(analisis).ToList();
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
