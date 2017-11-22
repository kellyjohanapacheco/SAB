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
        public string NumeroSerial { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string NombrePersonaCargo { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}