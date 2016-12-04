using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL.Tests
{
    [TestClass()]
    public class CitasBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Citas c = new Citas();
            c.NombreCliente = "Fernando";
            c.FechaHora = DateTime.Today;
            Assert.IsTrue(CitasBll.Guardar(c) != false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1, id2 = 2;
            Assert.AreNotSame(CitasBll.Buscar(id).FechaHora, CitasBll.Buscar(id2).FechaHora);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 2;
            Assert.IsFalse(CitasBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(UsuariosBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.AreEqual(CitasBll.GetLista().Count, CitasBll.GetLista().Count);
        }
        
    }
}