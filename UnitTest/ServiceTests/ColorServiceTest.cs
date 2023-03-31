using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain.ControlDeCalzado;
using Moq;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class ColorServiceTest
    {
        [TestMethod]
        public void GetAllColoresListaConElementos()
        {
            // Preparación
            var mockColor = new Mock<IColorService>();
            mockColor.Setup(sc => sc.GetAll()).Returns(new List<Color>() {
            new Color{ CodigoColor = "BN", DescripcionColor = "Blanco y Negro" },
            new Color{ CodigoColor = "MRN", DescripcionColor = "Azul Marino"}});

            // Ejecución
            var colores = mockColor.Object.GetAll();

            // Comprobación
            Assert.IsNotNull(colores);
            Assert.AreEqual(2, colores.Count());
        }

        [TestMethod]
        public void GetUnColorExitosamente()
        {
            // Preparación
            var id = "NGO";
            var mockColor = new Mock<IColorService>();
            var color = new Color { CodigoColor = "NGO", DescripcionColor = "Negro" };
            mockColor.Setup(r => r.Get("NGO")).Returns(new Color { CodigoColor = "NGO", DescripcionColor = "Negro" });
            mockColor.Setup(r => r.Get("BLC")).Returns(new Color { CodigoColor = "BLC", DescripcionColor = "Blanco" });
            // Ejecución
            var colores = mockColor.Object.Get(id);

            // Comprobación
            Assert.IsNotNull(colores);
            Assert.AreEqual("Negro", color.DescripcionColor);
        }

        [TestMethod]
        public void GetUnColorQueNoExisteDevuelveNull()
        {
            // Preparación
            var id = "MGN";
            var mockColor = new Mock<IColorService>();
            var color = new Color { CodigoColor = "NGO", DescripcionColor = "Negro" };
            mockColor.Setup(r => r.Get("NGO")).Returns(new Color { CodigoColor = "NGO", DescripcionColor = "Negro" });
            mockColor.Setup(r => r.Get("BLC")).Returns(new Color { CodigoColor = "BLC", DescripcionColor = "Blanco" });


            // Ejecución
            var colores = mockColor.Object.Get(id);

            // Comprobación
            Assert.IsNull(colores);
        }

        [TestMethod]
        public void CrearUnNuevoColorExitosamente()
        {
            // Preparación
            var color = new Color { CodigoColor = "NGO", DescripcionColor = "Negro" };
            var mockColor = new Mock<IColorService>();
            mockColor.Setup(r => r.Create(It.IsAny<Color>())).Callback((Color objeto) => { });
            // Ejecución
            mockColor.Object.Create(color);

            // Comprobación
            mockColor.Verify(r => r.Create(It.IsAny<Color>()), Times.Once);
        }

        [TestMethod]
        public void EditarUnColorExitosamente()
        {
            // Preparación
            var color = new Color { CodigoColor = "NGO", DescripcionColor = "Negro" };
            var mockColor = new Mock<IColorService>();
            mockColor.Setup(r => r.Get("NGO")).Returns(color);
            mockColor.Setup(r => r.Update(It.IsAny<Color>()))
        .Callback((Color objeto) => color.DescripcionColor = objeto.DescripcionColor);

            // Ejecución
            color.DescripcionColor = "black";
            mockColor.Object.Update(color);
            var colorActualizado = mockColor.Object.Get("NGO");

            // Comprobación
            Assert.AreEqual("black", colorActualizado.DescripcionColor);
        }

        //[TestMethod]
        //public void EliminarUnColorExitosamente()
        //{
        //    // Preparación
        //    var color = new Color { CodigoColor = "NGO", DescripcionColor = "Negro" };
        //    var mockColor = new Mock<IColorService>();
        //    mockColor.Setup(r => r.Get("NGO")).Returns(color);
        //    mockColor.Setup(r => r.Delete(It.IsAny<String>()))
        //.Callback((String id) => 
        //{
        //    var coloraeliminar = mockColor.Object.Get(id);
        //    coloraeliminar = null;
        //});

        //    // Ejecución
        //    mockColor.Object.Delete(color.CodigoColor);
        //    var obtenerColor = mockColor.Object.Get("NGO");

        //    // Comprobación
        //    Assert.IsNull(obtenerColor);
        //}
    }
}
