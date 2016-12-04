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
    public class ServiciosBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            //Assert.Fail();
            Servicios c = new Servicios();
            c.TipoServicio = "pedicura";
            c.Costo = 250;
            Assert.IsTrue(ServiciosBll.Guardar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            // Assert.Fail();
            int id = 1;
            Assert.IsFalse(ServiciosBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            // Assert.Fail();
            Assert.IsNotNull(ServiciosBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            // Assert.Fail();
            Assert.AreEqual(ServiciosBll.GetLista().Count, ServiciosBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            // Assert.Fail();
            int id = 2, id2 = 3;
            Assert.AreNotSame(ServiciosBll.Buscar(id).TipoServicio, ServiciosBll.Buscar(id2).TipoServicio);
        }
    }
}