using _2011600136_ENT.Entities;
using _2011600136_PER.EntytiTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_PER
{
    public class _2011600136Context : DbContext
    {
        public DbSet<Alimentacion> Alimentacions { get; set; }
        public DbSet<CalificacionHospedaje> CalificacionHospedajes { get; set; }
        public DbSet<CategoriaAlimentacion> CategoriaAlimentacions { get; set; }
        public DbSet<CategoriaHospedaje> CategoriaHospedajes { get; set; }
        public DbSet<CategoriaTransporte> CategoriaTransportes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
      //  public DbSet<ComprobantePago> ComprobantePagos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospedaje> Hospedajes { get; set; }
        public DbSet<MedioPago> MedioPagos { get; set; }
      //  public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<ServicioHospedaje> ServicioHospedajes { get; set; }
        public DbSet<ServicioTuristico> ServicioTuristicos { get; set; }
        public DbSet<TipoComprobante> Tipocomprobantes { get; set; }
        public DbSet<TipoHospedaje> TipoHospedajes { get; set; }
        public DbSet<TipoTransporte> TipoTransporte { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
    //    public DbSet<VentaPaquete> VentaPaquetes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Configurations.Add(new AlimentacionConfiguration());
            modelBuilder.Configurations.Add(new AlimentacionConfiguration());

            
            base.OnModelCreating(modelBuilder);
        }
    }
}
