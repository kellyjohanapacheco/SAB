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


        public ICollection<Datos.PrestamoActivo> PrestamoActivo { get; set; }

        public string Valor { get; set; }

        public string NumeroSerial { get; set; }

        public string NombrePersonaCargo { get; set; }
    }
}