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
        private static Datos.BienContext contexto = new Datos.BienContext();
        //
        // GET: /Bienes/
        public ActionResult Index()
        {
            List<Bien> bienes = contexto.Bien.OrderBy(p => p.IdBien).
                Select(p => new Bien()
                {
                    IdBien = p.IdBien,
                    Nombre = p.Nombre,
                    NombrePersonaCargo = p.NombrePersonaCargo,
                    NumeroSerial = p.NumeroSerial,
                    Valor = p.Valor,
                    
                }).ToList();

            return View(bienes);
              
                             
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

            Bien bien = new Bien();

            var tiposBien = new List<TipoBien>();
            tiposBien.Add(new TipoBien() { IdTipoBien = 1, Nombre = " Electronico" });
            tiposBien.Add(new TipoBien() { IdTipoBien = 1, Nombre = " Muebles y enceres" });
            tiposBien.Add(new TipoBien() { IdTipoBien = 1, Nombre = " Inmuebles" });
            tiposBien.Add(new TipoBien() { IdTipoBien = 1, Nombre = " Vehiculos" });


            ViewBag.TiposBien =
                tiposBien.Select(x => new SelectListItem
                {

                    Text = x.Nombre,
                    Value = x.IdTipoBien.ToString()

                });



            return View(bien);
        }

        //
        // POST: /Bienes/Registrar
        [HttpPost]
        public JsonResult RegistrarAJAX(Bien bien)
        {
            try
            {
                bienes.Add(bien);
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

        public IView bienes { get; set; }
    }
}
