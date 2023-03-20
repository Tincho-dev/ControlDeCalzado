using Common;
using Model.Domain.ControlDeCalzado;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlDeCalzado.Controllers
{
    public class LineaDeProduccionController : Controller
    {
        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: LineaDeProduccion
        public ActionResult Index()
        {
            var LineaDeProduccions = LineaDeProduccionService.GetAll();
            return View(LineaDeProduccions);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: LineaDeProduccion/Details/5
        public ActionResult Details(int id)
        {
            var LineaDeProduccion = LineaDeProduccionService.Get(id);
            return View(LineaDeProduccion);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: LineaDeProduccion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaDeProduccion/Create
        [HttpPost]
        public ActionResult Create(LineaDeProduccion LineaDeProduccion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Comprobamos que no haya una linea con el mismo numero
                    LineaDeProduccionService.Create(LineaDeProduccion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                    ModelState.AddModelError("Domain", e.Message);
                }
            }

            return View(LineaDeProduccion);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: LineaDeProduccion/Edit/5
        public ActionResult Edit(int id)
        {
            var model = LineaDeProduccionService.GetEdit(id);
            return View();
        }

        // POST: LineaDeProduccion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LineaDeProduccion LineaDeProduccion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LineaDeProduccionService.Update(LineaDeProduccion);
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: LineaDeProduccion/Delete/5
        public ActionResult Delete(int id)
        {
            var model = LineaDeProduccionService.Get(id);

            return View(model);
        }

        // POST: LineaDeProduccion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, LineaDeProduccion LineaDeProduccion)
        {
            try
            {
                LineaDeProduccionService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}