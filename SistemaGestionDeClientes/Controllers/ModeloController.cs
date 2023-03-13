using Model.Domain.ControlDeCalzado;
using Services;
using System;
using System.Web.Mvc;

namespace ControlDeCalzado.Controllers
{
    public class ModeloController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Modelo
        public ActionResult Index()
        {
            var modelos = ModeloService.GetAll();
            return View(modelos);
        }

        [Authorize(Roles = "Admin")]
        // GET: Modelo/Details/5
        public ActionResult Details(string id)
        {
            var modelo = ModeloService.Get(id);
            return View(modelo);
        }

        [Authorize(Roles = "Admin")]
        // GET: Modelo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modelo/Create
        [HttpPost]
        public ActionResult Create(Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                ModeloService.Create(modelo);

                return RedirectToAction("Index");
            }
            return View(modelo);
        }

        [Authorize(Roles = "Admin")]
        // GET: Modelo/Edit/5
        public ActionResult Edit(string id)
        {
            var model = ModeloService.GetEdit(id);
            return View(model);
        }

        // POST: Modelo/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Modelo modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ModeloService.Update(modelo);
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Modelo/Delete/5
        public ActionResult Delete(string id)
        {
            var model = ModeloService.Get(id);

            return View(model);
        }

        // POST: Modelo/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Modelo modelo)
        {
            try
            {
                ModeloService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
