using Model.Domain.ControlDeCalzado;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGestionDeClientes.Controllers
{
    public class TurnoController : Controller
    {
        // GET: Turno
        public ActionResult Index()
        {
			var turnos = TurnoService.GetAll();
			return View(turnos);
		}

        // GET: Turno/Details/5
        public ActionResult Details(int id)
        {
			var turnos = TurnoService.Get(id);
			return View(turnos);
		}

        // GET: Turno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turno/Create
        [HttpPost]
        public ActionResult Create(Turno turno)
        {
			if (ModelState.IsValid)
			{
				TurnoService.Create(turno);

				return RedirectToAction("Index");
			}
			return View(turno);
		}

        // GET: Turno/Edit/5
        public ActionResult Edit(int id)
        {
			var turno = TurnoService.Get(id);
			return View(turno);
		}

        // POST: Turno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Turno turno)
        {
			try
			{
				if (ModelState.IsValid)
				{
					TurnoService.Update(turno);
				}
				return RedirectToAction("Index");

			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

        // GET: Turno/Delete/5
        public ActionResult Delete(int id)
        {
			var turno = TurnoService.Get(id);

			return View(turno);
		}

        // POST: Turno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Turno turno)
        {
			try
			{
				TurnoService.Delete(id);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
    }
}
