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
     public class ComprobanteFMap:EntityTypeConfiguration<ComprobanteF>
    {
         public ComprobanteFMap()
         {
             this.HasKey(comF => comF.Id);
             this.Property(comF => comF.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
             this.Property(comF => comF.Total).HasPrecision(18,2).IsRequired();
             this.Property(comF => comF.subTotal).HasPrecision(18,2).IsRequired();
             this.Property(comF => comF.Igv).HasPrecision(18,2).IsRequired();

             this.ToTable("ComprobanteFactura");

             this.HasRequired(comF => comF.venta)
                      .WithMany(v => v.comprobanteF)
                      .HasForeignKey(comF => comF.ventaId)
                      .WillCascadeOnDelete(false);
         }
    }
}
