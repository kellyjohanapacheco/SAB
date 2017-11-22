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
        public Empleado IdEmpleado { get; set; }
        public string NumeroSerial { get; set; }
        public string Descripcion { get; set; }
        public Empleado PersonaCargo { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaFinalPrestamo { get; set; }
    }
}