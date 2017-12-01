using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAB.Datos
{
    public class Empleado
    {  
          public Empleado()
        {
            this.BienesACargo = new HashSet<Bien>();
        }
        
        [Key]
        public long IdEmpleado { get; set; }

        public string Nombre { get; set; }
        public string Documento { get; set; }
        public virtual ICollection<Bien> BienesACargo { get; set; }
    }

}