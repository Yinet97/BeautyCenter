using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Windows.Forms;

namespace BLL
{
    public class CitasBll
    {
        public static bool Guardar(Citas date)
        {
            bool retorno = false;

            try
            {
                using (var db = new BeautyCenterDb())
                {
                    if (Buscar(date.CitaId) == null)
                        db.Cita.Add(date);
                    else
                        db.Entry(date).State = EntityState.Modified;

                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }



        public static Citas Buscar(int id)
        {
            Citas date = new Citas();

            using (var db = new BeautyCenterDb())
            {
                date = db.Cita.Find(id);
            }
            return date;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;
            try
            {
                using (BeautyCenterDb db = new BeautyCenterDb())
                {
                    Citas date = (from c in db.Cita where c.CitaId == id select c).FirstOrDefault();
                    db.Cita.Remove(date);
                    db.SaveChanges();
                    retorno = true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return retorno;
        }

        public static bool EliminarCitaPasada(int cita)
        {
            bool retorno = false;

            try
            {
                using (BeautyCenterDb db = new BeautyCenterDb())
                {
                    Citas date = (from c in db.Cita where c.CitaId == cita select c).FirstOrDefault();
                    db.Cita.Remove(date);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static List<Citas> GetLista()
        {
            List<Citas> lista = new List<Citas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Cita.ToList();
            return lista;
        }

        public static List<Citas> GetLista(int id)
        {
            List<Citas> lista = new List<Citas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Cita.Where(u => u.CitaId == id).ToList();
            return lista;
        }

        public static List<Citas> GetLista(string nombre)
        {
            List<Citas> lista = new List<Citas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Cita.Where(u => u.NombreCliente == nombre).ToList();
            return lista;
        }

        public static List<Citas> GetListaFecha(DateTime desde, DateTime hasta)
        {
            List<Citas> lista = new List<Citas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Cita.Where(u => u.FechaHora >= desde.Date && u.FechaHora <= hasta).ToList();
            return lista;
        }
    }
}
