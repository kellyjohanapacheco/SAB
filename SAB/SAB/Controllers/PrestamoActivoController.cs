using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAB.Controllers
{
    public class PrestamoActivoController : Controller
    {
        //
        // GET: /Activo/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Activo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Activo/Create
        public ActionResult PrestamoActivo()
        {
            Empleado empleado = new Empleado() { Empleado = new Empleado) };

            var empleados = new List<Empleado>();
            empleados.Add(new Empleado() { IdEmpleado = 1, Nombre = " Electronico" });
            empleados.Add(new Empleado() { IdEmpleado = 1, Nombre = " Muebles y enceres" });
            empleados.Add(new Empleado() { IdEmpleado = 1, Nombre = " Inmuebles" });
            empleados.Add(new Empleado() { IdEmpleado = 1, Nombre = " Vehiculos" });


            ViewBag.Empleados =
                empleados.Select(x => new SelectListItem
                {

                    Text = x.Nombre,
                    Value = x.IdEmpleado.ToString()

                });



            return View(PrestamoActivo);
        }

        //
        // POST: /Activo/Create
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

        //
        // GET: /Activo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Activo/Edit/5
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

        //
        // GET: /Activo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Activo/Delete/5
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
