﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroConDetalle2.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using RegistroConDetalle2.Models;
namespace RegistroConDetalle2.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Ordenes ordenes = new Ordenes();

            ordenes.OrdenId = 0;
            ordenes.Fecha = DateTime.Now;
            ordenes.SuplidorId = 1;
            ordenes.Monto = 500;

            ordenes.OrdenesDetalle.Add(new OrdenesDetalle
            {
                Id = 0,
                OrdenId = ordenes.OrdenId,
                ProductoId = 1,
                Cantidad = 1000,
                Costo = 25
            });

            paso = OrdenesBLL.Guardar(ordenes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso;
            paso = OrdenesBLL.Existe(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Ordenes ordenes = new Ordenes();

            ordenes.OrdenId = 0;
            ordenes.Fecha = DateTime.Now;
            ordenes.SuplidorId = 1;
            ordenes.Monto = 500;

            ordenes.OrdenesDetalle.Add(new OrdenesDetalle
            {
                Id = 0,
                OrdenId = ordenes.OrdenId,
                ProductoId = 1,
                Cantidad = 500,
                Costo = 25
            });

            paso = OrdenesBLL.Insertar(ordenes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Ordenes ordenes = new Ordenes();

            ordenes.OrdenId = 5;
            ordenes.Fecha = DateTime.Now;
            ordenes.SuplidorId = 1;
            ordenes.Monto = 500;

            ordenes.OrdenesDetalle.Add(new OrdenesDetalle
            {
                Id = 0,
                OrdenId = ordenes.OrdenId,
                ProductoId = 1,
                Cantidad = 450,
                Costo = 25
            });

            paso = OrdenesBLL.Modificar(ordenes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            if (OrdenesBLL.Eliminar(4))
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var ordenes = OrdenesBLL.Buscar(5);
            if (ordenes != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = OrdenesBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetOrdenesTest()
        {
            bool paso;
            var lista = OrdenesBLL.GetOrdenes();

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }
    }
}