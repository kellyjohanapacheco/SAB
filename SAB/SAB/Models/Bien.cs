using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAB.Models
{
    public class Bien
    {

        public string TipoBien { get; set; }
        public long NumeroSerial { get; set; }
        public long Valor { get; set; }
        public string Descripcion { get; set; }
        public string NombrePersonaCargo { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}