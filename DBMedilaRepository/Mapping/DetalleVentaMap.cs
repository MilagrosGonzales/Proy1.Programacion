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
   public  class DetalleVentaMap:EntityTypeConfiguration<DetalleVenta>
    {
       public DetalleVentaMap()
       {
           
            this.HasKey(dv => dv.Item);
            this.Property(dv => dv.Item).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(dv => dv.Cantidad).IsRequired();
            this.Property(dv => dv.Precio).HasPrecision(18,2).IsRequired();

            this.Ignore(dv => dv.Monto);


            this.ToTable("DetalleVenta");

           
           this.HasRequired(dv => dv.venta)
                     .WithMany(v => v.detalleVenta)
                     .HasForeignKey( dv=> dv.VentaId)
                     .WillCascadeOnDelete(false);

       }
    }
}
