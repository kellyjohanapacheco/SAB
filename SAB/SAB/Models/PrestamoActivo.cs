using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SAB.Models
{
    public class PrestamoActivo
    {

        public Empleado Empleado { get; set; }
        public Bien Bien { get; set;}
        public string Descripcion { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaFinalPrestamo { get; set; }


    }
}