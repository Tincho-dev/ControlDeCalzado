using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain.ControlDeCalzado;
using Moq;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllColoresListaConElementos()
        {
            var mockColor = new Mock<IColorService>();
            mockColor.Setup(sc => sc.GetAll()).Returns(new List<Color>() { 
            new Color{ CodigoColor = "BN", DescripcionColor = "Blanco y Negro" },
            new Color{ CodigoColor = "MRN", DescripcionColor = "Azul Marino"}});

            var colores = mockColor.Object.GetAll();

            Assert.IsNotNull(colores);
        }  
    }
}
