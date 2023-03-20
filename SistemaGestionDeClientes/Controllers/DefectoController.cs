using Common;
using Model.Domain.ControlDeCalzado;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ControlDeCalzado.Controllers
{
    public class DefectoController : Controller
    {
        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: Defecto
        public ActionResult Index()
        {
            var Defectos = DefectoService.GetAll();
            return View(Defectos);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: Defecto/Details/5
        public ActionResult Details(int id)
        {
            var Defecto = DefectoService.Get(id);
            return View(Defecto);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: Defecto/Create
        public ActionResult Create()
        {
            var tiposDefecto  = new List<ConvertEnum>();
            foreach (TipoDefecto defecto in Enum.GetValues(typeof(TipoDefecto)))
                tiposDefecto.Add(new ConvertEnum
                {
                    Value = (int)defecto,
                    Text = defecto.ToString()
                });
            ViewBag.TiposDefecto = tiposDefecto;
            return View();
        }

        // POST: Defecto/Create
        [HttpPost]
        public ActionResult Create(Defecto Defecto)
        {
            if (ModelState.IsValid)
            {
                DefectoService.Create(Defecto);

                return RedirectToAction("Index");
            }
            return View(Defecto);
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: Defecto/Edit/5
        public ActionResult Edit(int id)
        {
            var tiposDefecto = new List<ConvertEnum>();
            foreach (TipoDefecto defecto in Enum.GetValues(typeof(TipoDefecto)))
                tiposDefecto.Add(new ConvertEnum
                {
                    Value = (int)defecto,
                    Text = defecto.ToString()
                });
            ViewBag.TiposDefecto = tiposDefecto;
            var model = DefectoService.GetEdit(id);
            return View(model);
        }

        // POST: Defecto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Defecto Defecto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DefectoService.Update(Defecto);
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [CustomAuthorize(Roles = "Admin, SuperLinea")]
        // GET: Defecto/Delete/5
        public ActionResult Delete(int id)
        {
            var model = DefectoService.Get(id);

            return View(model);
        }

        // POST: Defecto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Defecto Defecto)
        {
            try
            {
                DefectoService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
