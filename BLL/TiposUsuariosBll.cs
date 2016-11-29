using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class TiposUsuariosBll
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    if (Buscar(usuario.UsuarioId) == null)
                        db.Usuario.Add(usuario);
                    else
                        db.Entry(usuario).State = EntityState.Modified;

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
                    Usuarios user = (from c in db.Usuario where c.UsuarioId == id select c).FirstOrDefault();
                    db.Usuario.Remove(user);
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
        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Usuario.ToList();
            return lista;
        }

        public static List<Usuarios> GetLista(int id)
        {
            List<Usuarios> lista = new List<Usuarios>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Usuario.Where(u => u.UsuarioId == id).ToList();
            return lista;
        }

        public static TiposUsuarios Buscar(int id)
        {
            TiposUsuarios user = new TiposUsuarios();
            using (var db = new BeautyCenterDb())
            {
                user = db.TipoUsuario.Find(id);
            }
            return user;
        }
    }
}
