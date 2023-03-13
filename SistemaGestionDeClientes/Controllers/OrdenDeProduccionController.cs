using System;
using System.Collections.Generic;
using System.Linq;
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

        [Authorize]
        // GET: OrdenDeProduccion/Details/5
        public ActionResult Details(string id)
        {
            var OrdenDeProduccion = OrdenDeProduccionService.Get(id);
            return View(OrdenDeProduccion);
        }

        [Authorize(Roles = "Admin")]
        // GET: OrdenDeProduccion/Create
        public ActionResult Create()
        {
            ViewBag.CodigoColor = new SelectList(ColorService.GetAll(), "CodigoColor", "DescripcionColor");
            ViewBag.Sku = new SelectList(ModeloService.GetAll(), "Sku", "Denominacion");
            ViewBag.IdLinea = new SelectList(LineaDeProduccionService.GetAllAviable(), "IdLinea", "NumeroLinea");

            return View();
        }

        // POST: OrdenDeProduccion/Create
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        public ActionResult Delete(string id)
        {
            var model = OrdenDeProduccionService.Get(id);
            return View(model);
        }

        // POST: OrdenDeProduccion/Delete/5
        [HttpPost]
        [Authorize]
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

        public ActionResult IniciarInspeccion(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");
            ViewBag.Modelo = ModeloService.Get(op.Sku);
            ViewBag.Color = ColorService.Get(op.CodigoColor);
            ViewBag.DefectosR = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
            ViewBag.DefectosO = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
            ViewBag.horaActual = DateTime.Now.TimeOfDay;
            ViewBag.IdHOrarioDeControl = OrdenDeProduccionService.HorarioActual(id);

            return View("Inspeccionar", op);
        }
        public ActionResult ContinuarInspeccion(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);
            //OrdenDeProduccionService.AgregarJornada(id);
            OrdenDeProduccionService.AgregarHorarioDeControl(id);
            OrdenDeProduccionService.CargarAlertas(id);
            ViewBag.Defectos = new SelectList(DefectoService.GetAll(), "IdDefecto", "DescripcionDefecto");
            ViewBag.Modelo = ModeloService.Get(op.Sku);
            ViewBag.Color = ColorService.Get(op.CodigoColor);
            ViewBag.DefectosR = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
            ViewBag.DefectosO = DefectoService.GetAll().Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
            ViewBag.horaActual = DateTime.Now.TimeOfDay;
            ViewBag.IdHorarioDeControl = OrdenDeProduccionService.HorarioActual(id);

            return View("Inspeccionar", op);
        }

        //public ActionResult ChangeUserToOP(string numero, string user)
        //{
        //    var Op = OrdenDeProduccionService.GetOP(user);

        //    if (Op != null)
        //    {
        //        throw new ApplicationException("El Usuario ya tiene una Op asociada");
        //    }

        //    OrdenDeProduccionService.ChangeUserToOp(numero, user);
        //    return RedirectToAction("Index");
        //}

        #region Incidencias
        [HttpPost]
        public JsonResult ActualizarCantidad(int idHorarioDeControl, int cantidad)
        {
            OrdenDeProduccionService.RegistrarIncidencia(cantidad, idHorarioDeControl);
            //guardar valor en base de datos
            int nuevaCantidad = OrdenDeProduccionService.TotalIncidenciasPrimera(idHorarioDeControl);
            //OrdenDeProduccionService.UpdateCantidadDeParesDePrimera(numeroDeOrden, nuevaCantidad);

            return Json(nuevaCantidad);
        }
        [HttpPost]
        public JsonResult RegistrarDefecto(int idHorarioDeControl, int cantidad, int idDefecto, Pie pie, TipoDefecto tipoDefecto)
        {
            OrdenDeProduccionService.RegistrarIncidencia( cantidad,  idDefecto,  pie,  idHorarioDeControl);
            int totalInicidencias = OrdenDeProduccionService.TotalIncidenciasDefectoPorPie(idHorarioDeControl, pie, tipoDefecto);

            return Json(totalInicidencias);
        }
        #endregion
    }
}
