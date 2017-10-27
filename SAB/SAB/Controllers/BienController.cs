using SAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAB.Controllers
{
    public class BienController : Controller
    {
        //
        // GET: /Bienes/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Bienes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Bienes/Registrar
        public ActionResult Registrar()
        {
            return View();
        }

        //
        // POST: /Bienes/Registrar
        [HttpPost]
        public JsonResult RegistrarAJAX(Bien bien)
        {
            try
            {
                var json = Json(new { mensaje = "" });
                return json;
                
                
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
            }
        }

        //
        // GET: /Bienes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        // POST: /Bienes/Edit/5
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

        // POST: /Bienes/Registrar
        [HttpPost]
        public ActionResult Registrar(Bien bien)
        {
            return View(); 
        }




        //
        // GET: /Bienes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Bienes/Delete/5
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
