using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class BeautyCenterDb : DbContext
    {
        public BeautyCenterDb() : base("name = conStr")
        {

        }

        public virtual DbSet<Usuarios> Usuario { get; set; }
        public virtual DbSet<TiposUsuarios> TipoUsuario { get; set; }
        public virtual DbSet<Empleadas> Empleada { get; set; }
        public virtual DbSet<Clientes> Cliente { get; set; }
        public virtual DbSet<Servicios> Servicio { get; set; }
        public virtual DbSet<Citas> Cita { get; set; }
        public virtual DbSet<Facturas> Factura { get; set; }
        public virtual DbSet<FacturasServicios> FacturaServicios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facturas>()
                .HasMany<Servicios>(g => g.Service)
                .WithMany(e => e.Facturas)
                .Map(ge =>
                {
                    ge.MapLeftKey("ServicioId");
                    ge.MapRightKey("FacturaId");
                    ge.ToTable("FacturasServicios");
                });
        }
    }

}
