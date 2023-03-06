using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGestionDeClientes.Controllers
{
    public class AlertaController : Controller
    {
        // GET: Alerta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Semaforo()
        {
            int cantidadActual = 45;
            return View(cantidadActual);
        }

    }
}