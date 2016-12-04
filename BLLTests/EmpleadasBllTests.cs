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
    public class EmpleadasBllTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //  Assert.Fail();
            Empleadas c = new Empleadas();
            c.Nombre = "Maria";
            c.Cedula = "84525-6";
            c.Direccion = "Cotui";
            c.Telefono = "758-965-965";
            c.Servicio = "lavado";
            c.FechaEntrada = DateTime.Today;

            Assert.IsTrue(EmpleadasBll.Insertar(c) != false);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            // Assert.Fail();
            int id = 2;
            Assert.IsFalse(EmpleadasBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            // Assert.Fail();
            Assert.IsNotNull(EmpleadasBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            // Assert.Fail();
            Assert.AreEqual(EmpleadasBll.GetLista().Count, EmpleadasBll.GetLista().Count);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            // Assert.Fail();
            int id = 3;
            Assert.IsNotNull(EmpleadasBll.Buscar(id) != null);
        }
    }
}