using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using MedilaSystemEntities;
using DBMedilaRepository.Mapping;

namespace DBMedilaRepository
{
    public class DBMedilaSystemContext:DbContext
    {
        public DBMedilaSystemContext()
        {
          //Database.SetInitializer<DBMedilaSystemContext> (new DropCreateDatabaseAlways<DBMedilaSystemContext>());
          Database.SetInitializer<DBMedilaSystemContext>(null);
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Adquisicion> Adquisiciones { get; set; }
        public DbSet<HojaDeDevolucion> HojaDevoluciones { get; set; }
        public DbSet<DetalleAdquisicion> DetalleAdquisiciones { get; set; }
        public DbSet<DetalleDeDevolucion> DetalleDevoluciones { get; set; }
        public DbSet<Comprobante> Comprobante { get; set; }
        public DbSet<DetalleProforma> DetalleProformas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Proforma> Proformas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProveedorMap());
            modelBuilder.Configurations.Add(new AdquisicionMap());
            modelBuilder.Configurations.Add(new HojaDeDevolucionMap());
            modelBuilder.Configurations.Add(new DetalleAdquisicionMap());
            modelBuilder.Configurations.Add(new DetalleDevolucionMap());
            modelBuilder.Configurations.Add(new ComprobanteMap());
            modelBuilder.Configurations.Add(new DetalleProformaMap());
            modelBuilder.Configurations.Add(new DetalleVentaMap());
            modelBuilder.Configurations.Add(new ProformaMap());
            modelBuilder.Configurations.Add(new VentaMap());
            
        }
    }
}
