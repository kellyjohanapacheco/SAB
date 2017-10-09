using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAB.Controllers
{
    public class ImpresionController : Controller
    {
        //
        // GET: /Impresion/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Impresion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Impresion/Create
        public ActionResult Impresion()
        {
            return View();
        }

        //
        // POST: /Impresion/Create
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
        // GET: /Impresion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Impresion/Edit/5
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
        // GET: /Impresion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Impresion/Delete/5
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
