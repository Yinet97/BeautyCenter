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
    public class FacturasBll
    {
        public static bool Guardar(Facturas fact)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    if (Buscar(fact.FacturaId) == null)
                        db.Factura.Add(fact);
                    else
                        db.Entry(fact).State = EntityState.Modified;

                    foreach (var servicios in fact.Service)
                    {
                        db.Entry(servicios).State = EntityState.Unchanged;
                    }
                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return retorno;
        }

        public static Facturas Buscar(int id)
        {
            Facturas date = null;
            using (var db = new BeautyCenterDb())
            {
                date = db.Factura.Find(id);
                if (date != null)
                    date.Service.Count();
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
                    Facturas fact = (from c in db.Factura where c.FacturaId == id select c).FirstOrDefault();
                    db.Factura.Remove(fact);
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

        public static List<Facturas> GetLista()
        {
            List<Facturas> lista = new List<Facturas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Factura.ToList();
            return lista;
        }

        public static List<Facturas> GetLista(int id)
        {
            List<Facturas> lista = new List<Facturas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Factura.Where(u => u.FacturaId == id).ToList();
            return lista;
        }

        public static List<Facturas> GetListaFecha(DateTime desde, DateTime hasta)
        {
            List<Facturas> lista = new List<Facturas>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Factura.Where(u => u.Fecha >= desde.Date && u.Fecha <= hasta).ToList();
            return lista;
        }
    }
}
