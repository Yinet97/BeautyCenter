using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class EmpleadasBll
    {
        public static bool Insertar(Empleadas empleada)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    if (Buscar(empleada.EmpleadaId) == null)
                        db.Empleada.Add(empleada);
                    else
                        db.Entry(empleada).State = EntityState.Modified;

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

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (BeautyCenterDb db = new BeautyCenterDb())
                {
                    Empleadas user = (from c in db.Empleada where c.EmpleadaId == id select c).FirstOrDefault();
                    db.Empleada.Remove(user);
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
        public static List<Empleadas> GetLista()
        {
            List<Empleadas> lista = new List<Empleadas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Empleada.ToList();
            return lista;
        }

        public static List<Empleadas> GetLista(int id)
        {
            List<Empleadas> lista = new List<Empleadas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Empleada.Where(u => u.EmpleadaId == id).ToList();
            return lista;
        }

        public static Empleadas Buscar(int id)
        {
            Empleadas emp = new Empleadas();
            using (var db = new BeautyCenterDb())
            {
                emp = db.Empleada.Find(id);
            }
            return emp;
        }

        public static List<Empleadas> GetListaFecha(DateTime desde, DateTime hasta)
        {
            List<Empleadas> lista = new List<Empleadas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Empleada.Where(u => u.FechaEntrada >= desde.Date && u.FechaEntrada <= hasta).ToList();
            return lista;
        }
    }
}
