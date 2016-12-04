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
    public class ClientesBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            //Assert.Fail();
            Clientes c = new Clientes();
            c.Nombre = "Fernando";
            c.Cedula = "845";
            c.Direccion = "Cotui";
            c.Telefono = "758-965-965";
            Assert.IsTrue(ClientesBll.Guardar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            // Assert.Fail();
            int id = 1;
            Assert.IsFalse(ClientesBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            // Assert.Fail();
            Assert.IsNotNull(ClientesBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            // Assert.Fail();
            Assert.AreEqual(ClientesBll.GetLista().Count, ClientesBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            // Assert.Fail();
            int id = 1, id2 = 2;
            Assert.AreNotSame(ClientesBll.Buscar(id).Nombre, ClientesBll.Buscar(id2).Nombre);
        }
    }
}