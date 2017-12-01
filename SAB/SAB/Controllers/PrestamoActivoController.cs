using SAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAB.Controllers
{
    public class PrestamoActivoController : Controller
    {
        private static Datos.PrestamoActivoContext contexto = new Datos.PrestamoActivoContext();
        //
        // GET: /Activo/
        public ActionResult Index()
        {
            List<Empleado> PrestamosActivo = contexto.Empleados.OrderBy(p => p.IdEmpleado).
                Select(p => new Empleado()
                {
                   
        
                    IdEmpleado = p.IdEmpleado,
                    Nombre = p.Nombre,
                    Documento= p.Documento,


                }).ToList();

            return View(PrestamosActivo);


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

            var empleados = contexto.Empleados.OrderBy(e => e.Nombre).ToList(); 
            ViewBag.Empleados =
                empleados.Select(x => new SelectListItem
                {

                    Text = x.Nombre,
                    Value = x.IdEmpleado.ToString()

                });

            var bienes = contexto.Bienes.OrderBy(e => e.Nombre).ToList();
            ViewBag.Bienes =
                bienes.Select(x => new SelectListItem
                {

                    Text =x.NumeroSerial + " - " + x.Nombre +" - " + x.Empleado.Nombre,
                    Value = x.IdBien.ToString()

                });

            return View( new PrestamoActivo ());
        }

        //
        // POST: /Activo/Create
        [HttpPost]
        public JsonResult CrearAJAX(Empleado Empleado)
        {
            try
            {
            contexto.SaveChanges();

                var json = Json(new { mensaje = "" });
                return json;
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
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
