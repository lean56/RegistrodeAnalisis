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
                var Anterior = db.Analisi.Find(analisis.AnalisisId);

                foreach (var item in analisis.DetallesAnalisis)
                {
                    if (!analisis.DetallesAnalisis.Exists(d => d.Id == item.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;    
                   }           
                }

                db.Entry(analisis).State = EntityState.Modified;

                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }

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
            Contexto db = new Contexto();
            Analisis analisis = new Analisis();

            try
            {
                analisis = db.Analisi.Find(id);
                analisis.DetallesAnalisis.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
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
