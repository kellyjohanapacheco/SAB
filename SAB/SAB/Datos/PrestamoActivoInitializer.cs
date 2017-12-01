using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace SAB.Datos
{
    public class PrestamoActivoInitializer: DropCreateDatabaseIfModelChanges<PrestamoActivoContext>
    {
        protected override void Seed(PrestamoActivoContext context)
        {
            context.Empleados.Add(new Empleado() {Nombre = "Catalina", IdEmpleado = 1});
            context.Empleados.Add(new Empleado() {Nombre = "Manuela" , IdEmpleado = 2});

            context.Bienes.Add(new Bien() { Nombre = "Mueble", NumeroSerial = "45623", IdEmpleado =1});
            context.Bienes.Add(new Bien() { Nombre = "Edificio", NumeroSerial = "11253", IdEmpleado = 2 });
            base.Seed(context);
        }
    }
}