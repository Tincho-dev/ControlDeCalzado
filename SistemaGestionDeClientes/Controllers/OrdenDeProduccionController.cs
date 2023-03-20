using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Common;
using Model.Domain.ControlDeCalzado;
using Services;

namespace ControlDeCalzado.Controllers
{
    public class OrdenDeProduccionController : Controller
    {

        #region CRUD
        [Authorize]
        // GET: OrdenDeProduccion
        public ActionResult Index()
        {
            var OrdenDeProducciones = OrdenDeProduccionService.GetAll();
            return View(OrdenDeProducciones);
        }

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult IndexSupervisor()
        {
            var Ordenes = OrdenDeProduccionService.GetOPSupervisor(Common.CurrentUser.Get.UserId);
            return View(Ordenes);
        }

        [Authorize]
        // GET: OrdenDeProduccion/Details/5
        public ActionResult Details(string id)
        {
            var OrdenDeProduccion = OrdenDeProduccionService.GetDetails(id);
            return View(OrdenDeProduccion);
        }

        [CustomAuthorize(Roles = "SuperLinea, Admin")]
        // GET: OrdenDeProduccion/Create
        public ActionResult Create()
        {
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return View();
        }

        // POST: OrdenDeProduccion/Create
        [CustomAuthorize(Roles ="SuperLinea, Admin")]
        [HttpPost]
        public ActionResult Create(OrdenDeProduccion OrdenDeProduccion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    OrdenDeProduccionService.Create(OrdenDeProduccion);

                    return RedirectToAction("Index");
                }
            }
            catch (ApplicationException e)
            {
                ModelState.AddModelError("Domain",e.Message);
            }
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return View(OrdenDeProduccion);
        }

        private ControllerBase CargarModeloColorLinea()
        {
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return ViewBag;
        }


        // GET: OrdenDeProduccion/Edit/5
        [CustomAuthorize(Roles = "SuperLinea")]
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
        [CustomAuthorize(Roles ="SuperLinea")]
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
        [CustomAuthorize(Roles = "Admin")]
        public ActionResult Delete(string id)
        {
            var model = OrdenDeProduccionService.Get(id);
            return View(model);
        }

        // POST: OrdenDeProduccion/Delete/5
        [HttpPost]
        [CustomAuthorize(Roles = "Admin")]
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
        #endregion
        #region VistasInspeccion
        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult IniciarInspeccion(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            OrdenDeProduccionService.IniciarOp(id);

            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");
            ViewBag.Modelo = ModeloService.Get(op.Sku);
            ViewBag.Color = ColorService.Get(op.CodigoColor);
            ViewBag.DefectosR = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
            ViewBag.DefectosO = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
            ViewBag.horaActual = DateTime.Now.TimeOfDay;
            ViewBag.IdHOrarioDeControl = OrdenDeProduccionService.HorarioActual(id);

            //long poolling, contador para refrescar contador de alerta js y jquery para consultar y mostrar
            //boton de ver semaforo en inicio o en la vista de inspeccionar

            return View("Inspeccionar", op);
        }

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult ContinuarInspeccion(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            //OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            OrdenDeProduccionService.IniciarOp(id);

            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");
            ViewBag.Modelo = ModeloService.Get(op.Sku);
            ViewBag.Color = ColorService.Get(op.CodigoColor);
            ViewBag.DefectosR = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
            ViewBag.DefectosO = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
            ViewBag.horaActual = DateTime.Now.TimeOfDay;
            ViewBag.IdHorarioDeControl = OrdenDeProduccionService.HorarioActual(id);

            return View("Inspeccionar", op);
        }
        #endregion
        #region POST Incidencias
        [HttpPost]
        public JsonResult ActualizarCantidad(string numeroDeOrden, int idHorarioDeControl, int cantidad)
        {
            OrdenDeProduccionService.RegistrarIncidencia(cantidad, idHorarioDeControl);
            //guardar valor en base de datos
            int nuevaCantidad = OrdenDeProduccionService.TotalIncidenciasPrimeraEnHorarioDeControl(idHorarioDeControl);
            int totalParesDePrimera = OrdenDeProduccionService.TotalIncidenciasPrimera(numeroDeOrden);
            OrdenDeProduccionService.UpdateCantidadDeParesDePrimera(numeroDeOrden, totalParesDePrimera);

            return Json(nuevaCantidad);
        }
        [HttpPost]
        public JsonResult RegistrarDefecto(int idHorarioDeControl, int cantidad, int idDefecto, Pie pie, TipoDefecto tipoDefecto)
        {
            OrdenDeProduccionService.RegistrarIncidencia(cantidad, idDefecto, pie, idHorarioDeControl);
            int totalInicidencias = OrdenDeProduccionService.TotalIncidenciasDefectoPorPie(idHorarioDeControl, pie, tipoDefecto, idDefecto);

            return Json(totalInicidencias);
        }
        #endregion

        #region OP

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult TerminarOp(string id)
        {
            OrdenDeProduccionService.TerminarOp(id);
            return RedirectToAction("Details", new { id = id });
        }

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult PausarOp(string id)
        {
            OrdenDeProduccionService.PausarOp(id);
            return RedirectToAction("Details", new { id = id });  
        } 

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult CambiarEstadoOp(string id, EstadoOp estado)
        {
            OrdenDeProduccionService.CambiarEstadoOrdenDeProduccion(id, estado);
            return RedirectToAction("Details", new { id = id });  
        }
        #endregion

        #region Asignar y Desvincular Op

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        public ActionResult AsignarSupervisorDeCalidad(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = OrdenDeProduccionService.Get(id);

            UserService UserService = new UserService();

            ViewBag.Users = UserService.ObtenerSupervisoresDeCalidad();
            ViewBag.Modelo = ModeloService.Get(model.Sku);
            ViewBag.Color = ColorService.Get(model.CodigoColor);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        public ActionResult AsignarSupervisorDeCalidad(string numero, string user)
        {
            var Op = OrdenDeProduccionService.GetOP(user);

            if (Op != null)
            {
                ModelState.AddModelError("AsociarOP", "El Usuario ya tiene una Op asociada");
                //throw new ApplicationException("El Usuario ya tiene una Op asociada");
                return RedirectToAction("IndexSupervisor");
            }

            OrdenDeProduccionService.AsignarSupervisorCalidad(numero, user);
            return RedirectToAction("Index");
        }

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult AsociarmeAOp(string id)
        {
            var Op = OrdenDeProduccionService.GetOP(Common.CurrentUser.Get.UserId);

            if (Op != null)
            {
                ModelState.AddModelError("AsociarOP","El Usuario ya tiene una Op asociada");
                //throw new ApplicationException("El Usuario ya tiene una Op asociada");
                return RedirectToAction("IndexSupervisor");

            }

            OrdenDeProduccionService.AsociarmeAOp(id);
            return RedirectToAction("IndexSupervisor");
        }

        [CustomAuthorize(Roles = "SuperCalidad")]
        public ActionResult DesvincularSupervisorDeCalidadDeOp(string id)
        {

            OrdenDeProduccionService.DesvincularSupervisorDeCalidad(id);

            return RedirectToAction("IndexSupervisor");
        }

        #endregion

    }
}
