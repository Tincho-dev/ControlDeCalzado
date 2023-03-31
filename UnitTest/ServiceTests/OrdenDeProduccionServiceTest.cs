using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Custom;
using Model.Domain.ControlDeCalzado;
using Moq;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest.ServicesTests
{
	[TestClass]
	public class OrdenDeProduccionServiceTest
	{
		[TestMethod]
		public void TestObtenerTodasLasOrdenesDeProduccion()
		{
			// Preparación
			var op1 = new OrdenDeProduccionGrid {
				Numero = "1234", Linea = 1, Sku = "ADIDAS", Color = "NGO",Estado = EstadoOp.Pausada };
			var op2 = new OrdenDeProduccionGrid { 
				Numero = "1543", Linea = 34, Sku = "Nike", Color = "BCO",Estado = EstadoOp.Pausada };
			var date = DateTime.Parse("2023-01-01");
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();
			mockOrdenDeProduccion.Setup(sc => sc.GetAll()).Returns(new List<OrdenDeProduccionGrid>() { 
			op1,op2
			});

			// Ejecución
			var ordenesdeproduccion = mockOrdenDeProduccion.Object.GetAll();

			// Comprobación
			Assert.IsNotNull(ordenesdeproduccion);
			Assert.AreEqual(2, ordenesdeproduccion.Count());
		}

		[TestMethod]
		public void GetUnaOrdenDeProduccionExitosamente()
		{
			// Preparación
			var id = "1234";
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion {Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO",Estado = EstadoOp.Pausada });
			mockOrdenDeProduccion.Setup(r => r.Get("1543")).Returns(new OrdenDeProduccion {Numero = "1543", IdLinea = 34, Sku = "Nike", CodigoColor = "BCO",Estado = EstadoOp.Pausada });

			// Ejecución
			var ordendeproduccion = mockOrdenDeProduccion.Object.Get(id);

			// Comprobación
			Assert.IsNotNull(ordendeproduccion);
			Assert.AreEqual(1, ordendeproduccion.IdLinea);
			Assert.AreEqual("ADIDAS", ordendeproduccion.Sku);
		}


		[TestMethod]
		public void GetUnaOrdenDeProduccionQueNoExiste()
		{
			// Preparación
			var id = "1548";
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion { Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Pausada });
			mockOrdenDeProduccion.Setup(r => r.Get("1543")).Returns(new OrdenDeProduccion { Numero = "1543", IdLinea = 34, Sku = "Nike", CodigoColor = "BCO", Estado = EstadoOp.Pausada });

			// Ejecución
			var ordendeproduccion = mockOrdenDeProduccion.Object.Get(id);

			// Comprobación
			Assert.IsNull(ordendeproduccion);
		}

		[TestMethod]
		public void CrearUnaNuevaOrdenDeProduccionExitosamente()
		{
			// Preparación
			var op = new OrdenDeProduccion {
				Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO",Estado = EstadoOp.Pausada };
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Create(It.IsAny<OrdenDeProduccion>())).Callback((OrdenDeProduccion objeto) => { });
			// Ejecución
			mockOrdenDeProduccion.Object.Create(op);

			// Comprobación
			mockOrdenDeProduccion.Verify(r => r.Create(It.IsAny<OrdenDeProduccion>()), Times.Once);
		}

		[TestMethod]
		public void IniciarUnaOrdenDeProduccionExitosamente()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion { Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Pausada });
			mockOrdenDeProduccion.Setup(r => r.IniciarOp("1234")).Callback((String numero) => {
			var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				ordendeproduccion.Estado = EstadoOp.Iniciada;
			});

			// Ejecución
			mockOrdenDeProduccion.Object.IniciarOp("1234");
			var ordendeproduccionconnuevoestado = mockOrdenDeProduccion.Object.Get("1234");
			// Comprobación
			Assert.AreEqual("Iniciada", ordendeproduccionconnuevoestado.Estado.ToString());
		}

		[TestMethod]
		public void TerminarUnaOrdenDeProduccionExitosamente()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion { Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Iniciada });
			mockOrdenDeProduccion.Setup(r => r.TerminarOp("1234")).Callback((String numero) => {
				var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				ordendeproduccion.Estado = EstadoOp.Finalizada;
			});

			// Ejecución
			mockOrdenDeProduccion.Object.TerminarOp("1234");
			var ordendeproduccionconestadofinalizado = mockOrdenDeProduccion.Object.Get("1234");
			// Comprobación
			Assert.AreEqual("Finalizada", ordendeproduccionconestadofinalizado.Estado.ToString());
		}

		[TestMethod]
		public void PausarUnaOrdenDeProduccionExitosamente()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();

			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion { Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Iniciada });
			mockOrdenDeProduccion.Setup(r => r.PausarOp("1234")).Callback((String numero) => {
				var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				ordendeproduccion.Estado = EstadoOp.Pausada;
			});

			// Ejecucións
			mockOrdenDeProduccion.Object.PausarOp("1234");
			var ordendeproduccionpausada = mockOrdenDeProduccion.Object.Get("1234");
			// Comprobación
			Assert.AreEqual("Pausada", ordendeproduccionpausada.Estado.ToString());
		}

		[TestMethod]
		public void UpdateCantidadDePrimeraDeUnaOrdenDeProduccion()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();
			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion { 
				Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", 
				Estado = EstadoOp.Iniciada,CantidadDePrimera=16 });
			mockOrdenDeProduccion.Setup(r => r.UpdateCantidadDeParesDePrimera("1234", 17)).Callback((String numero, int cantidad)=>
			   { 
				var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				   ordendeproduccion.CantidadDePrimera = cantidad;
			   });

			// Ejecucións
			mockOrdenDeProduccion.Object.UpdateCantidadDeParesDePrimera("1234",17);
			var opconcantidaddeprimeraactualizada = mockOrdenDeProduccion.Object.Get("1234");

			// Comprobación
			Assert.IsNotNull(opconcantidaddeprimeraactualizada);
			Assert.AreEqual(17, opconcantidaddeprimeraactualizada.CantidadDePrimera);
		}

		[TestMethod]
		public void AsignarSupervisorDeCalidadAOrdenDeProduccionExitosamente()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();
			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion {
				Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Iniciada });
			mockOrdenDeProduccion.Setup(r => r.AsignarSupervisorCalidad("1234","543")).Callback((String numero, String userid)=>
			{
				var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				ordendeproduccion.UserId = userid;

			});

			// Ejecución
			mockOrdenDeProduccion.Object.AsignarSupervisorCalidad("1234", "543");
			var ordendeproduccionconsupervisordecalidad = mockOrdenDeProduccion.Object.Get("1234");

			// Comprobación
			Assert.AreEqual("543", ordendeproduccionconsupervisordecalidad.UserId);

		}

		[TestMethod]
		public void DesvincularSupervisorDeCalidadDeOrdenDeProduccionExitosamente()
		{
			// Preparación
			var mockOrdenDeProduccion = new Mock<IOrdenDeProduccionService>();
			mockOrdenDeProduccion.Setup(r => r.Get("1234")).Returns(new OrdenDeProduccion
			{
				Numero = "1234", IdLinea = 1, Sku = "ADIDAS", CodigoColor = "NGO", Estado = EstadoOp.Iniciada, UserId="543"
			});
			mockOrdenDeProduccion.Setup(r => r.DesvincularSupervisorDeCalidad("1234")).Callback((String numero) =>
			{
				var ordendeproduccion = mockOrdenDeProduccion.Object.Get(numero);
				ordendeproduccion.UserId = null;

			});

			// Ejecución
			mockOrdenDeProduccion.Object.DesvincularSupervisorDeCalidad("1234");
			var ordendeproduccionsinsupervisordecalidad = mockOrdenDeProduccion.Object.Get("1234");

			// Comprobación
			Assert.IsNull(ordendeproduccionsinsupervisordecalidad.UserId);

		}
	}
}
