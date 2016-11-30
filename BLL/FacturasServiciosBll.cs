using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class FacturasServiciosBll
    {
        public static bool Guardar(FacturasServicios lista)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    if (Buscar(lista.Id) == null)
                        db.FacturaServicios.Add(lista);
                    else
                        db.Entry(lista).State = EntityState.Modified;

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
                    FacturasServicios user = (from c in db.FacturaServicios where c.Id == id select c).FirstOrDefault();
                    db.FacturaServicios.Remove(user);
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

        public static List<FacturasServicios> GetLista()
        {
            List<FacturasServicios> lista = new List<FacturasServicios>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.FacturaServicios.ToList();
            return lista;
        }

        public static List<FacturasServicios> GetLista(int id)
        {
            List<FacturasServicios> lista = new List<FacturasServicios>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.FacturaServicios.Where(u => u.Id == id).ToList();
            return lista;
        }

        public static FacturasServicios Buscar(int id)
        {
            FacturasServicios fact = new FacturasServicios();
            using (BeautyCenterDb db = new BeautyCenterDb())
            {
                fact = db.FacturaServicios.Find(id);
            }
            return fact;
        }
    }
}
