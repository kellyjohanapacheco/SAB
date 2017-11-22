using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAB.Datos
{
    public class PrestamoActivoContext: DbContext
    {
        public PrestamoActivoContext() : base("name=PrestamoActivo")
        {
            Database.SetInitializer(new PrestamoActivoInitializer());
        }

        public DbSet<Empleado> Empleados { get; set;  }
        public DbSet<PrestamoActivo> PrestamosActivo { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PrestamoActivo>()
                .HasMany(p => p.Empleados)
                .WithRequired(p => p.Bien)
                .HasForeignKey(p => p.IdBien)
                .WillCascadeOnDelete(false);
            
            
            
            
            base.OnModelCreating(modelBuilder);
        }

    }
}