using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MedilaSystemEntities;

using System.ComponentModel.DataAnnotations.Schema;

namespace DBMedilaRepository.Mapping
{
   public  class ProductoMap:EntityTypeConfiguration<Producto>
    {
       public ProductoMap()
       {

            this.HasKey(p=>p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
            this.Property(p => p.Descripcion).HasMaxLength(200).IsRequired();
            this.Property(p=> p.PrecioUnitarioDeCompra).HasPrecision(18,2).IsRequired();
            this.Property(p => p.PrecioUnitarioDeVenta).HasPrecision(18,2).IsRequired();
            this.Property(p => p.IsEstado).IsRequired();

             this.ToTable("Productos");

             this.HasRequired(p => p.provedor)
                      .WithMany(prov=> prov.producto)
                      .HasForeignKey(p => p. ProveedorId)
                      .WillCascadeOnDelete(false);

          }
    }
}
