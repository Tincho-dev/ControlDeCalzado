using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain.ControlDeCalzado;
using Moq;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest.ServiceTests
{
	[TestClass]
	public class ModeloServiceTest
	{
        [TestMethod]
        public void GetAllListadoDeModelosExitosamente()
        {
            // Preparación
            var mockmodelo = new Mock<IModeloService>();
            mockmodelo.Setup(sc => sc.GetAll()).Returns(new List<Modelo>() {
            new Modelo{ Sku="ADID_SUP",Denominacion="Adida Superstar",LimiteInferiorDeObservado=7,LimiteInferiorDeReproceso=7,
            LimiteSuperiorDeObservado=7,LimiteSuperiorDeReproceso=7 },
            new Modelo{Sku="NIKE_PEG",Denominacion="Nike Pegasus 39",LimiteInferiorDeObservado=9,LimiteInferiorDeReproceso=9,
            LimiteSuperiorDeObservado=9,LimiteSuperiorDeReproceso=9  }
            });

            // Ejecución
            var modelos = mockmodelo.Object.GetAll();

            // Comprobación
            Assert.IsNotNull(modelos);
            Assert.AreEqual(2, modelos.Count());
        }

        [TestMethod]
        public void GetUnModeloExitosamente()
        {
            // Preparación
            var sku = "NIKE_PEG";
            var mockmodelo = new Mock<IModeloService>();
            mockmodelo.Setup(r => r.Get("ADID_SUP")).Returns(new Modelo{ Sku="ADID_SUP",Denominacion="Adida Superstar",LimiteInferiorDeObservado=7,LimiteInferiorDeReproceso=7,
            LimiteSuperiorDeObservado=7,LimiteSuperiorDeReproceso=7 });
            mockmodelo.Setup(r => r.Get("NIKE_PEG")).Returns(new Modelo{Sku="NIKE_PEG",Denominacion="Nike Pegasus 39",LimiteInferiorDeObservado=9,LimiteInferiorDeReproceso=9,
            LimiteSuperiorDeObservado=9,LimiteSuperiorDeReproceso=9 });
            // Ejecución
            var modelo = mockmodelo.Object.Get(sku);

            // Comprobación
            Assert.IsNotNull(modelo);
            Assert.AreEqual("Nike Pegasus 39", modelo.Denominacion);
        }

        [TestMethod]
        public void GetUnModeloQueNoExiste()
        {
            // Preparación
            var sku = "NIKE_RE";
            var mockmodelo = new Mock<IModeloService>();
            mockmodelo.Setup(r => r.Get("ADID_SUP")).Returns(new Modelo
            {Sku = "ADID_SUP",Denominacion = "Adida Superstar", LimiteInferiorDeObservado = 7,LimiteInferiorDeReproceso = 7,
                LimiteSuperiorDeObservado = 7,LimiteSuperiorDeReproceso = 7});
            mockmodelo.Setup(r => r.Get("NIKE_PEG")).Returns(new Modelo
            {Sku = "NIKE_PEG",Denominacion = "Nike Pegasus 39",LimiteInferiorDeObservado = 9, LimiteInferiorDeReproceso = 9,
                LimiteSuperiorDeObservado = 9,LimiteSuperiorDeReproceso = 9});
            // Ejecución
            var modelo = mockmodelo.Object.Get(sku);

            // Comprobación
            Assert.IsNull(modelo);
        }

        [TestMethod]
        public void CrearUnNuevoModeloExitosamente()
        {
            // Preparación
            var mod1 = new Modelo{ Sku="ADID_SUP",Denominacion="Adida Superstar",LimiteInferiorDeObservado=7,LimiteInferiorDeReproceso=7,
            LimiteSuperiorDeObservado=7,LimiteSuperiorDeReproceso=7 };
            var mockmodelo = new Mock<IModeloService>();
            mockmodelo.Setup(r => r.Create(It.IsAny<Modelo>())).Callback((Modelo objeto) => { });
            // Ejecución
            mockmodelo.Object.Create(mod1);

            // Comprobación
            mockmodelo.Verify(r => r.Create(It.IsAny<Modelo>()), Times.Once);
        }

        [TestMethod]
        public void EditarUnModeloExitosamente()
        {
            // Preparación
            var mod1 = new Modelo{ Sku="ADID_SUP",Denominacion="Adida Superstar",LimiteInferiorDeObservado=7,LimiteInferiorDeReproceso=7,
            LimiteSuperiorDeObservado=7,LimiteSuperiorDeReproceso=7 };
            var mockmodelo = new Mock<IModeloService>();
            mockmodelo.Setup(r => r.Get("ADID_SUP")).Returns(mod1);
            mockmodelo.Setup(r => r.Update(It.IsAny<Modelo>()))
        .Callback((Modelo objeto) => mod1.LimiteInferiorDeObservado = objeto.LimiteInferiorDeObservado);

            // Ejecución
            mod1.LimiteInferiorDeObservado = 10;
            mockmodelo.Object.Update(mod1);
            var modeloactuaizado = mockmodelo.Object.Get("ADID_SUP");

            // Comprobación
            Assert.AreEqual(10, modeloactuaizado.LimiteInferiorDeObservado);
        }

    }
}
