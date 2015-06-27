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
    public  class ComprobanteBMap:EntityTypeConfiguration<ComprobanteB>
    {
        public ComprobanteBMap()
        {
            this.HasKey(comB => comB.Id);
            this.Property(comB => comB.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(comB => comB.Total).HasPrecision(18,2).IsRequired();


            this.ToTable("ComprobanteBoleta");

            this.HasRequired(comB => comB.venta)
                     .WithMany(v => v.comprobanteB)
                     .HasForeignKey(comB => comB.VentaId)
                     .WillCascadeOnDelete(false);
        }
    }
}
