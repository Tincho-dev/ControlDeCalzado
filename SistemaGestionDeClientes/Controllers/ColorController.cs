using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Domain.ControlDeCalzado;
using Persistanse;
using Services;

namespace ControlDeCalzado.Controllers
{
    public class ColorController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Color
        public ActionResult Index()
        {
            var colores = ColorService.GetAll();
            return View(colores);
        }

        [Authorize(Roles = "Admin")]
        // GET: Color/Details/5
        public ActionResult Details(string id)
        {
            var color = ColorService.Get(id);
            return View(color);
        }

        public JsonResult Buscar(string term)
        {
            using(var db = new ApplicationDbContext())
            {
                var colores = db.Colores.Where(x => x.DescripcionColor.Contains(term))
                    .Select(x => new { value = x.CodigoColor, Descripcion = x.DescripcionColor }).Take(5).ToList();
                return Json(colores, JsonRequestBehavior.AllowGet);
            }
            //var result = ColorService.Buscar(term);
        }

        [Authorize(Roles = "Admin")]
        // GET: Color/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Color/Create

        [HttpPost]
        public ActionResult Create(Color color)
        {

            if (ModelState.IsValid)
            {
                ColorService.Create(color);

                return RedirectToAction("Index");
            }
            return View(color);
        }
        [Authorize(Roles = "Admin")]
        // GET: Color/Edit/5
        public ActionResult Edit(string id)
        {
            var model = ColorService.GetEdit(id);

            return View(model);
        }

        // POST: Color/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Color color)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ColorService.Update(color);
                }
                return RedirectToAction("Index");

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: Color/Delete/5
        public ActionResult Delete(string id)
        {
            var model = ColorService.Get(id);
            return View(model);
        }

        // POST: Color/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Color color)
        {
            try
            {
                ColorService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
