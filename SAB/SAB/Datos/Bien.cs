using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAB.Datos
{
    [Table ("Bienes")]
    public class Bien
    {

        public Bien()
        {
            this.PrestamoActivo = new HashSet<PrestamoActivo>();
        }




        [Key]
        public long IdBien { get; set; }
        public string Nombre { get; set; }
        public string NumeroSerial { get; set; }
        public string Descripcion { get; set; }
        public string NombrePersonaCargo { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaIngreso { get; set; }


        public virtual ICollection<PrestamoActivo> PrestamoActivo { get; set; }

    }
}