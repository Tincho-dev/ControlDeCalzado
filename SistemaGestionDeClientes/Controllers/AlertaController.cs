using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGestionDeClientes.Controllers
{
    public class AlertaController : Controller
    {
        [Authorize]
        // GET: Alerta
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Semaforo()
        {
            int cantidadActual = 45;
            return View(cantidadActual);
        }

    }
}