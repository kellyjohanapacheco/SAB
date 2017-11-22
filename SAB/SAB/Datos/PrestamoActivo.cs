using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SAB.Datos
{
    public class PrestamoActivo
    {
        [Key]
        public long IdPrestamoActivo { get; set; }
        public long IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Bien Bien { get; set; }
        public long IdBien { get; set;}
        public string NumeroSerial { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string NombrePersonaCargo { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}