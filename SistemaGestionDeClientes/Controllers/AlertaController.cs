using Model.Domain.ControlDeCalzado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGestionDeClientes.Controllers
{
    public class AlertaController : Controller
    {
        private int contador = 4;
        private int limiteInferior = 5;
        private int limiteSuperior = 10;
        // GET: Alerta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Semaforo()
        {
            return View(contador);
        }
        public JsonResult GetValue()
        {
            return Json(new { contador, limiteInferior, limiteSuperior }, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult GetValue()
        //{
        //    var random = new Random();
        //    var cantidad = random.Next(1, 100);

        //    var model = new Incidencia { CantidadIncidencia = cantidad };

        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}

    }
}