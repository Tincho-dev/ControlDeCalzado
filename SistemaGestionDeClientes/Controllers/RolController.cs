using Common;
using System.Web.Mvc;

namespace ControlDeCalzado.Controllers
{
    public class RolController : Controller
    {
        [CustomAuthorize(Roles = "Admin")]
        // GET: Rol
        public ActionResult Index()
        {
            return View();
        }
        [CustomAuthorize(Roles = "Admin")]
        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [CustomAuthorize(Roles = "Admin")]
        // GET: Rol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rol/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
