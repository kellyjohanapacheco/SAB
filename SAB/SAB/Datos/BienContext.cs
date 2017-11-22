using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAB.Datos
{
    public class BienContext: DbContext
    {
        public BienContext() : base("name=Bien")
        {
            Database.SetInitializer(new BienInicializador());
        }

        public DbSet<Empleado> Empleados { get; set;  }
        public DbSet<Bien> Bien { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Bien>()
                .HasMany(p => p.PrestamoActivo)
                .WithRequired(p => p.Bien)
                .HasForeignKey(p => p.IdBien)
                .WillCascadeOnDelete(false);
            
            
            
            
            base.OnModelCreating(modelBuilder);
        }

    }
}