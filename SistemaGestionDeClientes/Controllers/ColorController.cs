using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Domain.ControlDeCalzado;
using Services;

namespace ControlDeCalzado.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            var colores = ColorService.GetAll();
            return View(colores);
        }

        // GET: Color/Details/5
        public ActionResult Details(string id)
        {
            var color = ColorService.Get(id);
            return View(color);
        }

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
