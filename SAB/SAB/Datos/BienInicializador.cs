using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace SAB.Datos
{
    public class BienInicializador: DropCreateDatabaseIfModelChanges<BienContext>
    {
        protected override void Seed(BienContext context)
        {
            context.Empleados.Add(new Empleado()
            {
                Nombre = "Catalina",
                IdEmpleado = 1});
            context.Empleados.Add(new Empleado()
            {
                Nombre = "Manuela" ,
                IdEmpleado = 2});

            base.Seed(context);
        }
    }
}