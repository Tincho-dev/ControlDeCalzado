using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Common;
using Model.Domain.ControlDeCalzado;
using Services;

namespace ControlDeCalzado.Controllers
{
    public class OrdenDeProduccionController : Controller
    {

        // GET: OrdenDeProduccion
        public ActionResult Index()
        {
            var OrdenDeProducciones = OrdenDeProduccionService.GetAll();
            return View(OrdenDeProducciones);
        }

        // GET: OrdenDeProduccion/Details/5
        public ActionResult Details(string id)
        {
            var OrdenDeProduccion = OrdenDeProduccionService.Get(id);
            return View(OrdenDeProduccion);
        }
        
        // GET: OrdenDeProduccion/Details/5
        public ActionResult IniciarInspeccion(string id)
        {
            ViewBag.cantidadReprocesoIzq = 0;
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");

            return View(op);
        }

        public ActionResult ContinuarInspeccion(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            //OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");

            return View(op);
        }

        // GET: OrdenDeProduccion/Create
        public ActionResult Create()
        {
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return View();
        }

        // POST: OrdenDeProduccion/Create
        [HttpPost]
        public ActionResult Create(OrdenDeProduccion OrdenDeProduccion)
        {
            OrdenDeProduccion.UserId = Common.CurrentUser.Get.UserId;
            if (ModelState.IsValid)
            {
                OrdenDeProduccionService.Create(OrdenDeProduccion);

                return RedirectToAction("Index");
            }
            return View(OrdenDeProduccion);
        }

        // GET: OrdenDeProduccion/Edit/5
        public ActionResult Edit(string id)
        {
            var model = OrdenDeProduccionService.Get(id);
            var estados = new List<ConvertEnum>();
            foreach (EstadoOp estado in Enum.GetValues(typeof(EstadoOp)))
                estados.Add(new ConvertEnum
                {
                    Value = (int)estado,
                    Text = estado.ToString()
                });
            ViewBag.Estado = estados;
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return View(model);
        }

        // POST: OrdenDeProduccion/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, OrdenDeProduccion OrdenDeProduccion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    OrdenDeProduccionService.Update(OrdenDeProduccion);
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                throw new ApplicationException("No se pudo editar la Orden de Produccion" + OrdenDeProduccion.Numero);
            }
        }

        // GET: OrdenDeProduccion/Delete/5
        public ActionResult Delete(string id)
        {
            var model = OrdenDeProduccionService.Get(id);
            return View(model);
        }

        // POST: OrdenDeProduccion/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, OrdenDeProduccion OrdenDeProduccion)
        {
            try
            {
                OrdenDeProduccionService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ChangeUserToOP(string numero, string user)
        {
            var Op = OrdenDeProduccionService.GetOP(user);

            if (Op != null)
            {
                throw new ApplicationException("El Usuario ya tiene una Op asociada");                  
            }

            OrdenDeProduccionService.ChangeUserToOp(numero, user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ActualizarCantidad(string numeroDeOrden, int cantidad)
        {
            var op = OrdenDeProduccionService.Get(numeroDeOrden);

            int nuevaCantidad = op.CantidadDePrimera + cantidad;

            OrdenDeProduccionService.RegistrarIncidencia(cantidad);
            OrdenDeProduccionService.ObtenerHorarioDeControl().Incidencias.Add();
            //guardar valor en base de datos
            OrdenDeProduccionService.UpdateCantidadDeParesDePrimera(numeroDeOrden, nuevaCantidad);

            return Json(nuevaCantidad);
        }

        public JsonResult RegistrarDefecto(string idDefecto, string pie,int cantidad, string NumeroOp)
        {
            //Registrarmos nueva incidencia y la asociamos a la op
            IncidenciaService.RegistrarIncidenciaOp(NumeroOp, idDefecto, pie);
            //llamamos al servicio donde hace una consulta que devuelve la cantidad total de incidencias con ese defecfto
            int totalInicidencias = IncidenciaService.GetTotalIncidenciasOpDefectoPie(NumeroOp, IdDefecto, pie);

            return Json(totalInicidencias);
        }


        public JsonResult ActualizarCantidadDefectosReprocesoIzq(string numeroDeOrden,int cantidad)
        {
            int cantidadReprocesoIzq = (int)Session["cantidadReprocesoIzq"];

            int nuevaCantidad = cantidadReprocesoIzq + cantidad;

            Session["cantidadReprocesoIzq"] = nuevaCantidad;

            return Json(nuevaCantidad, JsonRequestBehavior.AllowGet);
        }
    }
}
