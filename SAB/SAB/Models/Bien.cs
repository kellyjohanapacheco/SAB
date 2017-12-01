using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAB.Models
{
    
    public class Bien
    {
        
        public long IdBien { get; set; }
        public string Nombre { get; set; }
        public string NumeroSerial { get; set; }
        public Empleado PersonaCargo { get; set; }





    }
}