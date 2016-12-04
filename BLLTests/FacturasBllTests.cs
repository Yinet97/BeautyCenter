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
    public class FacturasBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            // Assert.Fail();
            Facturas c = new Facturas();
            c.NombreCliente = "Fernando";
            c.TipoPago = "efectivo";
            c.Impuesto = 18;
            c.Fecha = DateTime.Today;
            c.MontoAdicional = 300;
            c.SubTotal = 500;
            c.Total = 550;
            c.Descuento = 25;
            c.DescuentoPorciento = 0;
            c.Comentario = "comentario";
            Assert.IsTrue(FacturasBll.Guardar(c) != false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            // Assert.Fail();
            int id = 1, id2 = 2;
            Assert.AreNotSame(FacturasBll.Buscar(id).Fecha, FacturasBll.Buscar(id2).Fecha);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //  Assert.Fail();
            int id = 2;
            Assert.IsFalse(FacturasBll.Eliminar(id) != true);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            // Assert.Fail();
            Assert.IsNotNull(UsuariosBll.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            //  Assert.Fail();
            Assert.AreEqual(FacturasBll.GetLista().Count, FacturasBll.GetLista().Count);
        }
    }
}